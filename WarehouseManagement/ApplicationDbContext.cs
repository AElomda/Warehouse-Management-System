using Microsoft.EntityFrameworkCore;
using WarehouseManagement.Models;

namespace WarehouseManagement.WarehouseContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=WarehouseManagementSystem;Trusted_Connection=True;Encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding Categories
            var category1 = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Electronics"
            };

            var category2 = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Clothing"
            };
            var category3 = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Books"
            };

            var category4 = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Furniture"
            };
            modelBuilder.Entity<Category>().HasData(category1, category2, category3, category4);

            // Seeding Products
            modelBuilder.Entity<Product>().HasData(
                // Products for Electronics
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Laptop",
                    Description = "A high-performance laptop",
                    Cost = 800m,
                    Price = 1000m,
                    Count = 50,
                    CategoryId = category1.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Smartphone",
                    Description = "Latest model smartphone",
                    Cost = 500m,
                    Price = 700m,
                    Count = 100,
                    CategoryId = category1.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Headphones",
                    Description = "Noise-cancelling wireless headphones",
                    Cost = 150m,
                    Price = 200m,
                    Count = 150,
                    CategoryId = category1.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Smartwatch",
                    Description = "A smartwatch with fitness tracking",
                    Cost = 120m,
                    Price = 180m,
                    Count = 80,
                    CategoryId = category1.Id
                },

                // Products for Clothing
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "T-Shirt",
                    Description = "Comfortable cotton t-shirt",
                    Cost = 10m,
                    Price = 20m,
                    Count = 200,
                    CategoryId = category2.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Jeans",
                    Description = "Denim jeans with a slim fit",
                    Cost = 30m,
                    Price = 50m,
                    Count = 150,
                    CategoryId = category2.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Jacket",
                    Description = "Warm winter jacket",
                    Cost = 70m,
                    Price = 100m,
                    Count = 60,
                    CategoryId = category2.Id
                },

                // Products for Books
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "C# Programming",
                    Description = "An in-depth guide to C# programming",
                    Cost = 25m,
                    Price = 40m,
                    Count = 120,
                    CategoryId = category3.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "ASP.NET Core Development",
                    Description = "Master ASP.NET Core development",
                    Cost = 30m,
                    Price = 50m,
                    Count = 80,
                    CategoryId = category3.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Entity Framework Core",
                    Description = "Learn EF Core with practical examples",
                    Cost = 20m,
                    Price = 35m,
                    Count = 110,
                    CategoryId = category3.Id
                },

                // Products for Furniture
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Dining Table",
                    Description = "Wooden dining table with a modern design",
                    Cost = 200m,
                    Price = 300m,
                    Count = 30,
                    CategoryId = category4.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Office Chair",
                    Description = "Ergonomic office chair with adjustable height",
                    Cost = 100m,
                    Price = 150m,
                    Count = 70,
                    CategoryId = category4.Id
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Sofa",
                    Description = "Comfortable 3-seater sofa",
                    Cost = 400m,
                    Price = 600m,
                    Count = 20,
                    CategoryId = category4.Id
                }
            );
        }
    }
}