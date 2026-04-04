using VagaBondTravelAPI.Models;

namespace TravelFrontend.Services
{
    public interface ITravelAPIService
    {
        public Task<IEnumerable<Destination>> GetAllAsync();
    }
}
