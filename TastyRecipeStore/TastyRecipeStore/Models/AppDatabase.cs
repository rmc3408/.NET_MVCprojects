using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyRecipeStore.Models
{
    public class AppDatabase : DbContext
    {
        public AppDatabase(DbContextOptions<AppDatabase> options) : base(options)
        {        }

        public DbSet<Recipe> PackofRecipes { get; set; }
    }
}
