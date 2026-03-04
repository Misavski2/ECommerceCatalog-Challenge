using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerceCatalog.Domain.Entities;

namespace ECommerceCatalog.Domain.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Guid id);
        Task<Product?> GetByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetAllAsync(string? category, decimal? minPrice, decimal? maxPrice, bool? isActive);
    }
}
