using System;


namespace ECommerceCatalog.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }
        public string ImageUrl { get; private set; }
        public bool IsActive { get; private set; }


        public Product(string name, string description, decimal price, string category, string imageUrl)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            ImageUrl = imageUrl;
            IsActive = true;
        }


        public void Update(string name, string description, decimal price, string category, string imageUrl)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            ImageUrl = imageUrl;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}
