using bhrugen_patel.Models;
using Microsoft.EntityFrameworkCore;

namespace bhrugen_patel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData([
                new Category() { Id= 1, Name="action", DisplayOrder = 1 },
                new Category() { Id = 2, Name = "scifi", DisplayOrder = 2 },
                new Category() { Id = 3, Name = "drama", DisplayOrder = 3 },
            ]);
        }

    }
}
