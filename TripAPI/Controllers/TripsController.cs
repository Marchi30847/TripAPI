using Microsoft.AspNetCore.Mvc;
using TripAPI.Contracts.Responses;
using TripAPI.Mappers;
using TripAPI.Services.Abstractions;

namespace TripAPI.Controllers;

[ApiController]
[Route("api/trips")]
public class TripsController : ControllerBase
{
    private readonly ITripService _tripService;

    public TripsController(ITripService tripService)
    {
        _tripService = tripService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(ICollection<GetAllTripsResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllTripsAsync(CancellationToken token)
    {
        var trips = await _tripService.GetAllTripsWithCountriesAsync(token);

        return Ok(trips.MapToGetAllTripsResponse());
    }
}