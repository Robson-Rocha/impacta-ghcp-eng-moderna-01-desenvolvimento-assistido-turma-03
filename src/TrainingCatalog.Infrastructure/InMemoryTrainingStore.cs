using TrainingCatalog.Application;
using TrainingCatalog.Domain;

namespace TrainingCatalog.Infrastructure;

public sealed class InMemoryTrainingStore : ITrainingStore
{
    private readonly object syncRoot = new();
    private readonly List<Training> trainings = [];

    public bool TryAdd(Training training)
    {
        lock (syncRoot)
        {
            if (trainings.Any(existing => existing.StartDate == training.StartDate))
            {
                return false;
            }

            trainings.Add(training);
            return true;
        }
    }

    public IReadOnlyList<Training> GetAll()
    {
        lock (syncRoot)
        {
            return trainings.ToList();
        }
    }

    public Training? GetById(Guid id)
    {
        lock (syncRoot)
        {
            return trainings.SingleOrDefault(training => training.Id == id);
        }
    }

    public TrainingUpdateResult Update(Training training)
    {
        lock (syncRoot)
        {
            var index = trainings.FindIndex(existing => existing.Id == training.Id);

            if (index < 0)
            {
                return TrainingUpdateResult.NotFound;
            }

            if (trainings.Any(existing => existing.Id != training.Id && existing.StartDate == training.StartDate))
            {
                return TrainingUpdateResult.StartDateConflict;
            }

            trainings[index] = training;
            return TrainingUpdateResult.Updated;
        }
    }

    public bool Delete(Guid id)
    {
        lock (syncRoot)
        {
            var training = trainings.SingleOrDefault(existing => existing.Id == id);

            if (training is null)
            {
                return false;
            }

            trainings.Remove(training);
            return true;
        }
    }
}