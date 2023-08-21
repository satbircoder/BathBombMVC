using BathBombMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BathBombMVC.DataAccess.Data
{

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name="Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, 
                    Name = "Tech Solution", 
                    StreetAddress="123 Main St",
                    City="Perth",PostalCode="6000",
                    State="WA",PhoneNumber="089547820" },
                new Company { Id = 2,
                    Name = "Vivid Box",
                    StreetAddress = "100 ST george terrace",
                    City = "Perth",
                    PostalCode = "6000",
                    State = "WA",
                    PhoneNumber = "089547822"
                },
                new Company { Id = 3,
                    Name = "Rider Supplies",
                    StreetAddress = "13 Lester Drive",
                    City = "Perth",
                    PostalCode = "6108",
                    State = "WA",
                    PhoneNumber = "089547823"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Artifact",
                    Size = "220G BATH BOMB",
                    Description = "Gaze at this ancient relic of blue steel, purple iris, and liquid gold foam",
                    Flavour = "Salted Caramel",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId= 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Wild Child",
                    Size = "220G BATH BOMB",
                    Description = "\"Wild\" is the perfect word to describe the hypnotic bath art this bath bomb creates.",
                    Flavour = "Cake Batter",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Coffee Snob",
                    Size = "220G BATH BOMB",
                    Description = "Don't worry, we understand your desire for artisanal and one of a kind products, and the Coffee Snob is just that.",
                    Flavour = "Fresh Coffee",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Jam Donut",
                    Size = "220G BATH BOMB",
                    Description = "Jam Donut has a white fizzy base with a hidden pink centre, topped with pink cocoa butter glaze, vegan sprinkles, and biodegradable silver glitter.",
                    Flavour = "Raspberry Jam",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Counting Sheep",
                    Size = "220G BATH BOMB",
                    Description = "Fall asleep with the restful smell of lavender and warm tonka",
                    Flavour = " Lavender & Tonka",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    ProductName = "Apple Donut",
                    Size = "220G BATH BOMB",
                    Description = "Apple Donut has a coral pink fizzy base, topped with white cocoa butter glaze, vegan sprinkles, and biodegradable gold glitter.",
                    Flavour = "Spiced Apple",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                }

                );
        }
    }
}
