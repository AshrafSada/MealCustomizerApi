namespace MealCustomizerApi.Api.MealRecords;

public record UpsertMealRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savories,
    List<string> Sweets);