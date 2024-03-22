namespace BuberBreakfast.Contracts.Breakfast;
public record BreakfastResponse
(
    Guid Id,
    string name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> sweet
);

