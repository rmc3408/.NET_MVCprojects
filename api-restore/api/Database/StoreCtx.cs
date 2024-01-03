using api.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Database
{
    public class StoreCtx : DbContext
    {
        public StoreCtx(DbContextOptions<StoreCtx> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(SeedData.seed());
        }
    }
}