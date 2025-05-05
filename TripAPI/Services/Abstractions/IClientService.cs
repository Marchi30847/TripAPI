using TripAPI.Entities;
using Trips.API.Contracts.Requests;

namespace TripAPI.Services.Abstractions;

public interface IClientService
{
    public Task<ICollection<ClientTrip>?> GetAllClientTripsAsync(int clientId, CancellationToken token = default);
    public Task<int> CreateClientAsync(CreateClientRequest client, CancellationToken token = default);
    public Task<bool> DeleteTourByIdAsync(int userId, int tripId, CancellationToken token = default);
}