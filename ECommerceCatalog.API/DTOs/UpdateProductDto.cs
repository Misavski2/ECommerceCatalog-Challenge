using System;

namespace ECommerceCatalog.API.DTOs
{
    public record UpdateProductDto(Guid Id, string Name, string Description, decimal Price, string Category, string ImageUrl);
}
