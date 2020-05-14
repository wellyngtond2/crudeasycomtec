using CrudNetAngular.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNetAngular.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Developer> Developer { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<TalentBase> TalentBase { get; set; }
    }
}
