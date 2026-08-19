using TrainingCatalog.Application;

namespace TrainingCatalog.Infrastructure;

public sealed class InMemoryTrainingStore : ITrainingStore
{
    private readonly List<Training> trainings = [];
    private readonly Lock sync = new();

    public bool TryAdd(Training training)
    {
        lock (sync)
        {
            if (trainings.Any(existing => existing.StartDate == training.StartDate))
            {
                return false;
            }

            trainings.Add(training);
            return true;
        }
    }

    public IReadOnlyCollection<Training> GetAll()
    {
        lock (sync)
        {
            return trainings.ToArray();
        }
    }

    public Training? GetById(Guid id)
    {
        lock (sync)
        {
            return trainings.FirstOrDefault(training => training.Id == id);
        }
    }

    public UpdateTrainingResult Update(Training training)
    {
        lock (sync)
        {
            var index = trainings.FindIndex(existing => existing.Id == training.Id);

            if (index < 0)
            {
                return UpdateTrainingResult.NotFound;
            }

            if (trainings.Any(existing => existing.Id != training.Id && existing.StartDate == training.StartDate))
            {
                return UpdateTrainingResult.StartDateConflict;
            }

            trainings[index] = training;
            return UpdateTrainingResult.Updated;
        }
    }

    public bool Delete(Guid id)
    {
        lock (sync)
        {
            var index = trainings.FindIndex(training => training.Id == id);

            if (index < 0)
            {
                return false;
            }

            trainings.RemoveAt(index);
            return true;
        }
    }
}