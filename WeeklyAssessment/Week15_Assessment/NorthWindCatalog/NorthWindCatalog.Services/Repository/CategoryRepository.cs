using Microsoft.EntityFrameworkCore;
using NorthWindCatalog.Services.Data;
using NorthWindCatalog.Services.Models;

namespace NorthWindCatalog.Services.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MyAppDbContext _context;
        public CategoryRepository(MyAppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
