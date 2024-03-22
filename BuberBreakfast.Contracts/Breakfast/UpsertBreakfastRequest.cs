namespace BuberBreakfast.Contracts.Breakfast;
public record UpsertBreakfastRequest
(
    string name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> sweet
);

