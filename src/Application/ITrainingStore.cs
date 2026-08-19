namespace TrainingCatalog.Application;

public enum UpdateTrainingResult
{
    Updated,
    NotFound,
    StartDateConflict
}

public interface ITrainingStore
{
    bool TryAdd(Training training);

    IReadOnlyCollection<Training> GetAll();

    Training? GetById(Guid id);

    UpdateTrainingResult Update(Training training);

    bool Delete(Guid id);
}