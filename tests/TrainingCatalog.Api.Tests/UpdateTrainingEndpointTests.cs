using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace TrainingCatalog.Api.Tests;

public sealed class UpdateTrainingEndpointTests
{
    [Fact]
    public async Task Put_with_valid_training_updates_resource()
    {
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();
        var createdTraining = await CreateTrainingAsync(client, "Introdução ao C#", DateOnly.FromDateTime(DateTime.UtcNow).AddDays(1));
        var request = new
        {
            title = "C# avançado",
            description = "Recursos avançados da linguagem C#.",
            startDate = createdTraining.StartDate,
            durationHours = 12
        };

        var response = await client.PutAsJsonAsync($"/api/trainings/{createdTraining.Id}", request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal(createdTraining.Id, document.RootElement.GetProperty("id").GetGuid());
        Assert.Equal(request.title, document.RootElement.GetProperty("title").GetString());
        Assert.Equal(request.durationHours, document.RootElement.GetProperty("durationHours").GetInt32());
    }

    [Fact]
    public async Task Put_with_invalid_training_returns_validation_error()
    {
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();
        var createdTraining = await CreateTrainingAsync(client, "Introdução ao C#", DateOnly.FromDateTime(DateTime.UtcNow).AddDays(1));
        var request = new
        {
            title = "",
            description = "Fundamentos da linguagem C#.",
            startDate = createdTraining.StartDate,
            durationHours = 8
        };

        var response = await client.PutAsJsonAsync($"/api/trainings/{createdTraining.Id}", request);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal("O título é obrigatório.", document.RootElement.GetProperty("errors").GetProperty("title")[0].GetString());
    }

    [Fact]
    public async Task Put_with_unknown_identifier_returns_not_found()
    {
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();
        var request = new
        {
            title = "Introdução ao C#",
            description = "Fundamentos da linguagem C#.",
            startDate = DateOnly.FromDateTime(DateTime.UtcNow).AddDays(1).ToString("yyyy-MM-dd"),
            durationHours = 8
        };

        var response = await client.PutAsJsonAsync($"/api/trainings/{Guid.NewGuid()}", request);

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task Put_with_another_trainings_start_date_returns_conflict()
    {
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();
        var firstTraining = await CreateTrainingAsync(client, "Introdução ao C#", DateOnly.FromDateTime(DateTime.UtcNow).AddDays(1));
        var secondTraining = await CreateTrainingAsync(client, "C# avançado", DateOnly.FromDateTime(DateTime.UtcNow).AddDays(2));
        var request = new
        {
            title = firstTraining.Title,
            description = firstTraining.Description,
            startDate = secondTraining.StartDate,
            durationHours = firstTraining.DurationHours
        };

        var response = await client.PutAsJsonAsync($"/api/trainings/{firstTraining.Id}", request);

        Assert.Equal(HttpStatusCode.Conflict, response.StatusCode);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal("Já existe um treinamento com esta data de início.", document.RootElement.GetProperty("errors").GetProperty("startDate")[0].GetString());
    }

    private static async Task<TrainingResponse> CreateTrainingAsync(HttpClient client, string title, DateOnly startDate)
    {
        var request = new
        {
            title,
            description = "Fundamentos da linguagem C#.",
            startDate = startDate.ToString("yyyy-MM-dd"),
            durationHours = 8
        };

        var response = await client.PostAsJsonAsync("/api/trainings", request);

        Assert.Equal(HttpStatusCode.Created, response.StatusCode);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        return new TrainingResponse(
            document.RootElement.GetProperty("id").GetGuid(),
            document.RootElement.GetProperty("title").GetString()!,
            document.RootElement.GetProperty("description").GetString()!,
            document.RootElement.GetProperty("startDate").GetString()!,
            document.RootElement.GetProperty("durationHours").GetInt32());
    }

    private sealed record TrainingResponse(Guid Id, string Title, string Description, string StartDate, int DurationHours);
}