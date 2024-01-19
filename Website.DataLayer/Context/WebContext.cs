using Microsoft.EntityFrameworkCore;
using Website.DataLayer.Entities;


namespace Website.DataLayer.Context
{
    public class WebContext :DbContext
    {
        public WebContext(DbContextOptions<WebContext> options) :base(options)
        {
            
        }
        
        public DbSet<Products> Products { get; set; }
      
        public DbSet<User> Users { get; set; }
        
        public DbSet<ShoppingCarts> shoppingCarts { get; set; }
        public DbSet<ContactUs> contactUs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        }

    }
}
