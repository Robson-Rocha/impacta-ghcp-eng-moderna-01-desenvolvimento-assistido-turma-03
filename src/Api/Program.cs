using System.Globalization;
using TrainingCatalog.Application;
using TrainingCatalog.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITrainingStore, InMemoryTrainingStore>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapPost("/api/trainings", (CreateTrainingRequest request, ITrainingStore store) =>
{
	var errors = new Dictionary<string, string[]>();

	if (string.IsNullOrWhiteSpace(request.Title))
	{
		errors["title"] = ["O título é obrigatório."];
	}

	if (string.IsNullOrWhiteSpace(request.Description))
	{
		errors["description"] = ["A descrição é obrigatória."];
	}

	var startDate = default(DateOnly);

	if (string.IsNullOrWhiteSpace(request.StartDate) ||
		!DateOnly.TryParseExact(request.StartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
	{
		errors["startDate"] = ["A data de início deve ser informada no formato YYYY-MM-DD."];
	}

	if (request.DurationHours <= 0)
	{
		errors["durationHours"] = ["A carga horária deve ser maior que zero."];
	}

	if (errors.Count > 0)
	{
		return Results.BadRequest(new { errors });
	}

	var training = new Training(
		Guid.NewGuid(),
		request.Title!,
		request.Description!,
		startDate,
		request.DurationHours);

	if (!store.TryAdd(training))
	{
		return Results.Conflict(new
		{
			errors = new Dictionary<string, string[]>
			{
				["startDate"] = ["Já existe um treinamento com esta data de início."]
			}
		});
	}

	return Results.Created($"/api/trainings/{training.Id}", training);
})
	.Produces<Training>(StatusCodes.Status201Created)
	.Produces(StatusCodes.Status400BadRequest)
	.Produces(StatusCodes.Status409Conflict);

app.Run();

public partial class Program;
