using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace TrainingCatalog.Api.Tests;

public sealed class CreateTrainingEndpointTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task Post_with_valid_training_returns_created_resource()
    {
        var client = factory.CreateClient();
        var request = new
        {
            title = "Introdução ao C#",
            description = "Fundamentos da linguagem C#.",
            startDate = "2026-09-15",
            durationHours = 8
        };

        var response = await client.PostAsJsonAsync("/api/trainings", request);

        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        Assert.NotNull(response.Headers.Location);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.True(document.RootElement.TryGetProperty("id", out var identifier));
        Assert.NotEqual(Guid.Empty, identifier.GetGuid());
        Assert.Equal("Introdução ao C#", document.RootElement.GetProperty("title").GetString());
    }

    [Fact]
    public async Task Post_with_blank_title_returns_validation_error()
    {
        var client = factory.CreateClient();
        var request = new
        {
            title = "",
            description = "Introdução ao C#",
            startDate = "2026-09-15",
            durationHours = 8
        };

        var response = await client.PostAsJsonAsync("/api/trainings", request);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal("O título é obrigatório.", document.RootElement.GetProperty("errors").GetProperty("title")[0].GetString());
    }

    [Fact]
    public async Task Post_with_past_start_date_returns_validation_error()
    {
        var client = factory.CreateClient();
        var request = new
        {
            title = "Introdução ao C#",
            description = "Fundamentos da linguagem C#.",
            startDate = DateOnly.FromDateTime(DateTime.UtcNow).AddDays(-1).ToString("yyyy-MM-dd"),
            durationHours = 8
        };

        var response = await client.PostAsJsonAsync("/api/trainings", request);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal("A data de início deve ser hoje ou uma data futura.", document.RootElement.GetProperty("errors").GetProperty("startDate")[0].GetString());
    }
}