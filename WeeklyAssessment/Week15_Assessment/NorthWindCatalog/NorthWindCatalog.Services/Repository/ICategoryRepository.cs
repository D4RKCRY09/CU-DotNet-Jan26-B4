using NorthWindCatalog.Services.Models;

namespace NorthWindCatalog.Services.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }

}

