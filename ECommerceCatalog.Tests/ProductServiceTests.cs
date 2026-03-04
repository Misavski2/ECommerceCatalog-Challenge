using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using ECommerceCatalog.Application.Services;
using ECommerceCatalog.Domain.Entities;
using ECommerceCatalog.Domain.Repositories;

namespace ECommerceCatalog.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public async Task UpdateProductAsync_ShouldThrowException_WhenProductDoesNotExist()
        {
            
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>()))
                    .ReturnsAsync((Product?)null);

            var service = new ProductService(mockRepo.Object);
            var productToUpdate = new Product("Produto Falso", "Desc", 100m, "Cat", "url");

            
            var exception = await Assert.ThrowsAsync<Exception>(() => service.UpdateProductAsync(productToUpdate));

            Assert.Equal("Produto não encontrado.", exception.Message);
        }

        [Fact]
        public async Task AddProductAsync_ShouldCallRepository_WhenProductIsValid()
        {
            
            var mockRepo = new Mock<IProductRepository>();
            var service = new ProductService(mockRepo.Object);
            var newProduct = new Product("Novo Produto", "Desc", 50m, "Cat", "url");

            
            await service.AddProductAsync(newProduct);

            
            mockRepo.Verify(repo => repo.AddAsync(It.IsAny<Product>()), Times.Once);
        }
    }
}