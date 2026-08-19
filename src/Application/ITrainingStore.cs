namespace TrainingCatalog.Application;

public interface ITrainingStore
{
    bool TryAdd(Training training);
}