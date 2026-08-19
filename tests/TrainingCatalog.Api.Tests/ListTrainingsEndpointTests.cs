using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace TrainingCatalog.Api.Tests;

public sealed class ListTrainingsEndpointTests
{
    [Fact]
    public async Task Get_with_empty_catalog_returns_empty_collection()
    {
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();

        var response = await client.GetAsync("/api/trainings");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal(JsonValueKind.Array, document.RootElement.ValueKind);
        Assert.Empty(document.RootElement.EnumerateArray());
    }

    [Fact]
    public async Task Get_after_creating_training_returns_created_training()
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

        var creationResponse = await client.PostAsJsonAsync("/api/trainings", request);
        var response = await client.GetAsync("/api/trainings");

        Assert.Equal(HttpStatusCode.Created, creationResponse.StatusCode);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        using var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        var training = Assert.Single(document.RootElement.EnumerateArray());
        Assert.Equal(request.title, training.GetProperty("title").GetString());
    }
}