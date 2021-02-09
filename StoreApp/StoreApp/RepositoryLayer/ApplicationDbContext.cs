using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROJECTONE.ModelLayer.Data.Models;
using StoreApp.ModelLayer.Data.Models;

namespace RepositoryLayer
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public DbSet<Location> Location { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }






        public ApplicationDbContext() { }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:shoestoreproj1.database.windows.net,1433;Initial Catalog=Project1;Persist Security Info=False;User ID=project1;Password=password123!;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                base.OnConfiguring(optionsBuilder);
            }
        }


    }
}
