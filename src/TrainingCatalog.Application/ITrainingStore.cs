using TrainingCatalog.Domain;

namespace TrainingCatalog.Application;

public interface ITrainingStore
{
    bool TryAdd(Training training);

    IReadOnlyList<Training> GetAll();

    Training? GetById(Guid id);

    TrainingUpdateResult Update(Training training);

    bool Delete(Guid id);
}

public enum TrainingUpdateResult
{
    Updated,
    NotFound,
    StartDateConflict
}