using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerceCatalog.Domain.Entities;
using ECommerceCatalog.Domain.Repositories;

namespace ECommerceCatalog.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task<Product?> GetProductByIdAsync(Guid id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task UpdateProductAsync(Product product)
        {
            var existingProduct = await _productRepository.GetByIdAsync(product.Id);
            if (existingProduct == null)
            {
                throw new Exception("Produto não encontrado.");
            }

            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(Guid id)
        {
            var existingProduct = await _productRepository.GetByIdAsync(id);
            if (existingProduct != null)
            {
                await _productRepository.DeleteAsync(id);
            }
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(string? category, decimal? minPrice, decimal? maxPrice, bool? isActive)
        {
            return await _productRepository.GetAllAsync(category, minPrice, maxPrice, isActive);
        }
    }
}