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
}