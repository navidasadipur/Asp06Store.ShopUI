using Microsoft.EntityFrameworkCore;

namespace Asp06Store.ShopUI.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Mobile",
                },
                new Category
                {
                    Id = 2,
                    Name = "Loptop",
                },
                new Category
                {
                    Id = 3,
                    Name = "Pc",
                }
                );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "sumsumng 1",
                Description = "sumsumng 1 best mobile for this price",
                Price = 30_000_000
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "sumsumng 2",
                Description = " sumsumng 2 best mobile for this price",
                Price = 30_000_000
            },
             new Product
             {
                 Id = 3,
                 CategoryId = 1,
                 Name = "IPhone 3",
                 Description = " IPhone 2 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 4,
                 CategoryId = 1,
                 Name = "IPhone 4",
                 Description = " IPhone 4 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 5,
                 CategoryId = 1,
                 Name = "Xiomi 5",
                 Description = " IPhone 5 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 6,
                 CategoryId = 2,
                 Name = "asus 6",
                 Description = "sumsumng 1 best mobile for this price",
                 Price = 30_000_000
             },
            new Product
            {
                Id = 7,
                CategoryId = 2,
                Name = "hp 7",
                Description = " sumsumng 2 best mobile for this price",
                Price = 30_000_000
            },
             new Product
             {
                 Id = 8,
                 CategoryId = 2,
                 Name = "vivo 8",
                 Description = " IPhone 2 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 9,
                 CategoryId = 2,
                 Name = "asus 9",
                 Description = " IPhone 4 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 10,
                 CategoryId = 2,
                 Name = "Xiomi 10",
                 Description = " IPhone 5 best mobile for this price",
                 Price = 30_000_000
             },
            new Product
            {
                Id = 11,
                CategoryId = 3,
                Name = "pc 11",
                Description = " sumsumng 2 best mobile for this price",
                Price = 30_000_000
            },
             new Product
             {
                 Id = 12,
                 CategoryId = 3,
                 Name = "vivo 12",
                 Description = " IPhone 2 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 13,
                 CategoryId = 3,
                 Name = "asus 13",
                 Description = " IPhone 4 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 14,
                 CategoryId = 3,
                 Name = "asus 14",
                 Description = " IPhone 4 best mobile for this price",
                 Price = 30_000_000
             }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
