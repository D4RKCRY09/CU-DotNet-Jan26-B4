using NorthWindCatalog.Services.DTOs;
using NorthWindCatalog.Services.Models;

namespace NorthWindCatalog.Services.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId);
        Task<IEnumerable<CategorySummaryDto>> GetCategorySummariesAsync();
    }

}


