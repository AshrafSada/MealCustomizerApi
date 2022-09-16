namespace MealCustomizerApi.Contracts.MealRecords;

public record CreateMealResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savories,
    List<string> Sweets);