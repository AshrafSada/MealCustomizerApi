namespace MealCustomizerApi.Api.MealRecords;

public record CreateMealRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savories,
    List<string> Sweets);
