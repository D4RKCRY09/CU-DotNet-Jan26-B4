using VagaBondTravelAPI.Models;

namespace VagaBond.TravelAPI.Repository
{
    public interface IDestinationRepository
    {
        public Task<IEnumerable<Destination>> GetAllAsync();
        public Task<Destination> GetByIdAsync(int id);
        public Task AddAsync(Destination destination);
        public Task UpdateAsync(Destination destination);
        public Task DeleteAsync(int id);
    }
}
