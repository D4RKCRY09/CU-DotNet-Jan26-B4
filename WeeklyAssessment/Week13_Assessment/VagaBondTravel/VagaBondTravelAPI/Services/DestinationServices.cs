using VagaBond.TravelAPI.Data;
using VagaBond.TravelAPI.Repository;
using VagaBondTravelAPI.Models;

namespace VagaBond.TravelAPI.Services
{
    public class DestinationServices : IDestinationServices
    {
        private readonly IDestinationRepository _repo;

        public DestinationServices(IDestinationRepository repo)
        {
            _repo = repo;
        }

        public async Task AddAsync(Destination destination)
        {
            await _repo.AddAsync(destination);
        }

        public async Task DeleteAsync(int id)
        {
            var check = await _repo.GetByIdAsync(id);
            if (check == null) throw new ArgumentException("Destination does not exist");
            await _repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<Destination>> GetAllAsync()
        {
            var destinations = await _repo.GetAllAsync();
            if (destinations == null || !destinations.Any()) throw new ArgumentException("No destinations found");
            return destinations;
        }

        public async Task<Destination> GetByIdAsync(int id)
        {
            var check = await _repo.GetByIdAsync(id);
            if (check == null) throw new ArgumentException("Destination does not exist");
            return check;
        }

        public async Task UpdateAsync(Destination destination)
        {
            var check = await _repo.GetByIdAsync(destination.Id);
            if (check == null) throw new ArgumentException("Destination does not exist");
            
            // Update only the mutable properties
            check.CityName = destination.CityName;
            check.Country = destination.Country;
            check.Description = destination.Description;
            check.Rating = destination.Rating;
            check.LastVisited = destination.LastVisited;
            
            await _repo.UpdateAsync(check);
        }
    }
}
