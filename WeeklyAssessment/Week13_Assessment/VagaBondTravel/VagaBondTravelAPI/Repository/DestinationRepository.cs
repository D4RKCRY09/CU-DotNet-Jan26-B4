using VagaBondTravelAPI.Models;
using VagaBond.TravelAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace VagaBond.TravelAPI.Repository
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly VagaBondTravelAPIContext _context;

        public DestinationRepository(VagaBondTravelAPIContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Destination destination)
        {
            await _context.AddAsync(destination);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var destination = await _context.Destination.FindAsync(id);
            if (destination != null)
            {
                _context.Destination.Remove(destination);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Destination>> GetAllAsync()
        {
            return await _context.Destination.ToListAsync();
        }

        public async Task<Destination?> GetByIdAsync(int id)
        {
            return await _context.Destination.FindAsync(id);
        }

        public async Task UpdateAsync(Destination destination)
        {
            _context.Destination.Update(destination);
            await _context.SaveChangesAsync();
        }
    }
}
