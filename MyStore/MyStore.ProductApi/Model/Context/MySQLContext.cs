using Microsoft.EntityFrameworkCore;

namespace MyStore.ProductApi.Model.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 2,
                    Name = "T-Shirt Coffee M",
                    Price = new decimal(69.9),
                    Description = "It is a long established fact that a reader",
                    ImageURL = @"https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true",
                    Category = "T-Shirt"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3,
                    Name = "T-Shirt Gamer M",
                    Price = new decimal(59.9),
                    Description = "It is a long established fact that a reader",
                    ImageURL = @"https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true",
                    Category = "T-Shirt"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 4,
                    Name = "T-Shirt SpaceX M",
                    Price = new decimal(39.9),
                    Description = "It is a long established fact that a reader",
                    ImageURL = @"https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true",
                    Category = "T-Shirt"
                }
            );
        }
    }
}
