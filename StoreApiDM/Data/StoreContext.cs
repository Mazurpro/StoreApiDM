using Microsoft.EntityFrameworkCore;
using StoreApiDM.Models;
using StoreApiDM.Services;

namespace StoreApiDM.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Raincheck> Rainchecks { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
