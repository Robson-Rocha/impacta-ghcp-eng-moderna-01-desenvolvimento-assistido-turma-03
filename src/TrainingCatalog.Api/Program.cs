using TrainingCatalog.Application;
using TrainingCatalog.Domain;
using TrainingCatalog.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ITrainingStore, InMemoryTrainingStore>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/trainings", (ITrainingStore trainingStore) => Results.Ok(trainingStore.GetAll()))
	.Produces<IReadOnlyList<Training>>(StatusCodes.Status200OK);

app.MapGet("/api/trainings/{id:guid}", (Guid id, ITrainingStore trainingStore) =>
{
	var training = trainingStore.GetById(id);

	return training is null ? Results.NotFound() : Results.Ok(training);
})
	.Produces<Training>(StatusCodes.Status200OK)
	.Produces(StatusCodes.Status404NotFound);

app.MapDelete("/api/trainings/{id:guid}", (Guid id, ITrainingStore trainingStore) =>
	trainingStore.Delete(id) ? Results.NoContent() : Results.NotFound())
	.Produces(StatusCodes.Status204NoContent)
	.Produces(StatusCodes.Status404NotFound);

app.MapPut("/api/trainings/{id:guid}", (Guid id, UpdateTrainingRequest request, ITrainingStore trainingStore) =>
{
	var errors = new Dictionary<string, string[]>();
	var startDate = request.StartDate.GetValueOrDefault();

	if (string.IsNullOrWhiteSpace(request.Title))
	{
		errors["title"] = ["O título é obrigatório."];
	}

	if (string.IsNullOrWhiteSpace(request.Description))
	{
		errors["description"] = ["A descrição é obrigatória."];
	}

	if (request.StartDate is null)
	{
		errors["startDate"] = ["A data de início é obrigatória."];
	}
	else if (startDate < DateOnly.FromDateTime(DateTime.UtcNow))
	{
		errors["startDate"] = ["A data de início deve ser hoje ou uma data futura."];
	}

	if (request.DurationHours <= 0)
	{
		errors["durationHours"] = ["A carga horária deve ser maior que zero."];
	}

	if (errors.Count > 0)
	{
		return Results.ValidationProblem(errors);
	}

	var training = new Training(
		id,
		request.Title!.Trim(),
		request.Description!.Trim(),
		startDate,
		request.DurationHours);

	return trainingStore.Update(training) switch
	{
		TrainingUpdateResult.Updated => Results.Ok(training),
		TrainingUpdateResult.NotFound => Results.NotFound(),
		TrainingUpdateResult.StartDateConflict => Results.Conflict(new
		{
			errors = new Dictionary<string, string[]>
			{
				["startDate"] = ["Já existe um treinamento com esta data de início."]
			}
		}),
		_ => throw new InvalidOperationException("Resultado de atualização desconhecido.")
	};
})
	.Produces<Training>(StatusCodes.Status200OK)
	.ProducesValidationProblem(StatusCodes.Status400BadRequest)
	.Produces(StatusCodes.Status404NotFound)
	.Produces(StatusCodes.Status409Conflict);

app.MapPost("/api/trainings", (CreateTrainingRequest request, ITrainingStore trainingStore) =>
{
	var errors = new Dictionary<string, string[]>();
	var startDate = request.StartDate.GetValueOrDefault();

	if (string.IsNullOrWhiteSpace(request.Title))
	{
		errors["title"] = ["O título é obrigatório."];
	}

	if (string.IsNullOrWhiteSpace(request.Description))
	{
		errors["description"] = ["A descrição é obrigatória."];
	}

	if (request.StartDate is null)
	{
		errors["startDate"] = ["A data de início é obrigatória."];
	}
	else if (startDate < DateOnly.FromDateTime(DateTime.UtcNow))
	{
		errors["startDate"] = ["A data de início deve ser hoje ou uma data futura."];
	}

	if (request.DurationHours <= 0)
	{
		errors["durationHours"] = ["A carga horária deve ser maior que zero."];
	}

	if (errors.Count > 0)
	{
		return Results.ValidationProblem(errors);
	}

	var training = new Training(
		Guid.NewGuid(),
		request.Title!.Trim(),
		request.Description!.Trim(),
		startDate,
		request.DurationHours);

	if (!trainingStore.TryAdd(training))
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
	.ProducesValidationProblem(StatusCodes.Status400BadRequest)
	.Produces(StatusCodes.Status409Conflict);

app.Run();

public partial class Program;

public sealed record CreateTrainingRequest(
	string? Title,
	string? Description,
	DateOnly? StartDate,
	int DurationHours);

public sealed record UpdateTrainingRequest(
	string? Title,
	string? Description,
	DateOnly? StartDate,
	int DurationHours);
