namespace TripAPI.Exceptions;

public class ClientDoesNotExistException(int clientId) : Exception($"Client with {clientId} does not exist");