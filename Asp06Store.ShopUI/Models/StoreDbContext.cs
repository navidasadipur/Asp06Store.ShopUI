using Microsoft.EntityFrameworkCore;

namespace Asp06Store.ShopUI.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Category = "Mobile",
                Name = "sumsumng 1",
                Description = "sumsumng 1 best mobile for this price",
                Price = 30_000_000
            },
            new Product
            {
                Id = 2,
                Category = "Mobile",
                Name = "sumsumng 2",
                Description = " sumsumng 2 best mobile for this price",
                Price = 30_000_000
            },
             new Product
             {
                 Id = 3,
                 Category = "Mobile",
                 Name = "IPhone 3",
                 Description = " IPhone 2 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 4,
                 Category = "Mobile",
                 Name = "IPhone 4",
                 Description = " IPhone 4 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 5,
                 Category = "Mobile",
                 Name = "Xiomi 5",
                 Description = " IPhone 5 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 6,
                 Category = "Loptop",
                 Name = "asus 6",
                 Description = "sumsumng 1 best mobile for this price",
                 Price = 30_000_000
             },
            new Product
            {
                Id = 7,
                Category = "Loptop",
                Name = "hp 7",
                Description = " sumsumng 2 best mobile for this price",
                Price = 30_000_000
            },
             new Product
             {
                 Id = 8,
                 Category = "Loptop",
                 Name = "vivo 8",
                 Description = " IPhone 2 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 9,
                 Category = "Loptop",
                 Name = "asus 9",
                 Description = " IPhone 4 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 10,
                 Category = "Loptop",
                 Name = "Xiomi 10",
                 Description = " IPhone 5 best mobile for this price",
                 Price = 30_000_000
             },
            new Product
            {
                Id = 11,
                Category = "Pc",
                Name = "pc 11",
                Description = " sumsumng 2 best mobile for this price",
                Price = 30_000_000
            },
             new Product
             {
                 Id = 12,
                 Category = "Pc",
                 Name = "vivo 12",
                 Description = " IPhone 2 best mobile for this price",
                 Price = 30_000_000
             },
             new Product
             {
                 Id = 13,
                 Category = "Pc",
                 Name = "asus 13",
                 Description = " IPhone 4 best mobile for this price",
                 Price = 30_000_000
             }, 
             new Product
             {
                 Id = 14,
                 Category = "Pc",
                 Name = "asus 14",
                 Description = " IPhone 4 best mobile for this price",
                 Price = 30_000_000
             }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
