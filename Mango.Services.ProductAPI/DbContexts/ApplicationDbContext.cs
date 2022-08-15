using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new List<Product>() 
            { 
                new Product
                {
                    ProductId = 1,
                    Name = "Samosa",
                    Price = 15,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu.",
                    ImageUrl = "https://dotnetmastery.blob.core.windows.net/mango/14.jpg",
                    CategoryName = "Appetizer"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Paneer Tikka",
                    Price = 13.99,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu.",
                    ImageUrl = "https://dotnetmastery.blob.core.windows.net/mango/12.jpg",
                    CategoryName = "Appetizer"
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Sweet Pie",
                    Price = 10.99,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu.",
                    ImageUrl = "https://dotnetmastery.blob.core.windows.net/mango/11.jpg",
                    CategoryName = "Dessert"
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Pav Bhaji",
                    Price = 15,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu.",
                    ImageUrl = "https://dotnetmastery.blob.core.windows.net/mango/13.jpg",
                    CategoryName = "Entree"
                }
            });
        }
    }
}
