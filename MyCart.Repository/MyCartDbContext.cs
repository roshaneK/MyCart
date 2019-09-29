using Microsoft.EntityFrameworkCore;
using MyCart.Repository.Models;

namespace MyCart.Repository
{
    public class MyCartDbContext : DbContext
    {
        public MyCartDbContext(DbContextOptions<MyCartDbContext> options)
            : base(options)
        { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasOne(p => p.Cart)
                .WithMany(b => b.Items);
        }


    }
}
