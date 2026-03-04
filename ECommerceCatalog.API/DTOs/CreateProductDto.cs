using System;

namespace ECommerceCatalog.API.DTOs
{
    public record CreateProductDto(string Name, string Description, decimal Price, string Category, string ImageUrl);
}
