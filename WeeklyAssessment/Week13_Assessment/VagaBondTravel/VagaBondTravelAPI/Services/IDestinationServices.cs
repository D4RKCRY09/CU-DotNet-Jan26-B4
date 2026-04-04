using VagaBondTravelAPI.Models;

namespace VagaBond.TravelAPI.Services
{
    public interface IDestinationServices
    {
        public Task<IEnumerable<Destination>> GetAllAsync();
        public Task<Destination> GetByIdAsync(int id);
        public Task AddAsync(Destination destination);
        public Task UpdateAsync(Destination destination);
        public Task DeleteAsync(int id);
    }
}
