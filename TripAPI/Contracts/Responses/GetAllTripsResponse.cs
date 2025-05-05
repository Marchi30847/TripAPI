namespace TripAPI.Contracts.Responses;

public record struct GetAllTripsResponse(
    int Id,
    string Name,
    string Description,
    DateTime DateFrom,
    DateTime DateTo,
    int MaxPeople,
    List<CountryResponse> Countries);