using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerceCatalog.Domain.Entities;

namespace ECommerceCatalog.Application.Services
{
    public interface IProductService
    {
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(Guid id);
        Task<Product?> GetProductByIdAsync(Guid id);
        Task<IEnumerable<Product>> GetProductsAsync(string? category, decimal? minPrice, decimal? maxPrice, bool? isActive);
    }
}