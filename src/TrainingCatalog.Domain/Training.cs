namespace TrainingCatalog.Domain;

public sealed record Training(
    Guid Id,
    string Title,
    string Description,
    DateOnly StartDate,
    int DurationHours);