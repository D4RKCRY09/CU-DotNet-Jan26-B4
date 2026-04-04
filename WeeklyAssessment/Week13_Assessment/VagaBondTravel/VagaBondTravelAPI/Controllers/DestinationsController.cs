using Microsoft.AspNetCore.Mvc;
using VagaBond.TravelAPI.Services;
using VagaBondTravelAPI.Models;

namespace VagaBond.TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {
        private readonly IDestinationServices _services;

        public DestinationsController(IDestinationServices services)
        {
            _services = services;
        }

        // GET: api/Destinations
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Destination>>> GetDestination()
        {
            try
            {
                var destinations = await _services.GetAllAsync();
                return Ok(destinations);
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        // GET: api/Destinations/5
        [HttpGet("Get/{id}")]
        public async Task<ActionResult<Destination>> GetDestination(int id)
        {
            try
            {
                var destination = await _services.GetByIdAsync(id);
                return Ok(destination);
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        // PUT: api/Destinations/5
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutDestination(int id, Destination destination)
        {
            if (id != destination.Id)
            {
                return BadRequest(new { message = "ID in URL must match ID in request body" });
            }

            try
            {
                await _services.UpdateAsync(destination);
                return Ok(new { message = "Destination updated successfully" });
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        // POST: api/Destinations
        [HttpPost("Create")]
        public async Task<ActionResult<Destination>> PostDestination(Destination destination)
        {
            await _services.AddAsync(destination);
            return Ok();
        }

        // DELETE: api/Destinations/5
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteDestination(int id)
        {
            try
            {
                await _services.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
