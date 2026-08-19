using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace TrainingCatalog.Api.Tests;

public sealed class DeleteTrainingEndpointTests
{
    [Fact]
    public async Task Delete_with_existing_identifier_returns_no_content()
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
        using var creationDocument = JsonDocument.Parse(await creationResponse.Content.ReadAsStringAsync());
        var identifier = creationDocument.RootElement.GetProperty("id").GetGuid();

        var response = await client.DeleteAsync($"/api/trainings/{identifier}");

        Assert.Equal(HttpStatusCode.Created, creationResponse.StatusCode);
        Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        Assert.Empty(await response.Content.ReadAsByteArrayAsync());
    }

    [Fact]
    public async Task Delete_with_unknown_identifier_returns_not_found()
    {
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();

        var response = await client.DeleteAsync($"/api/trainings/{Guid.NewGuid()}");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}