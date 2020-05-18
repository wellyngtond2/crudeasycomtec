using CrudNetAngular.Core.Models;
using CrudNetAngular.Data.Initial_Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CrudNetAngular.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Knowledge>().HasData(KnowledgeSeed.GetKnowledgesSeed());
            modelBuilder.Entity<Occupation>().HasData(OccupationSeed.GetOccupationsSeed());
            
            modelBuilder.Entity<TalentBaseXKnowledge>().Ignore("Id").HasKey(k => new { k.TalentBaseId, k.KnowledgeId });
            modelBuilder.Entity<TalentBaseXOccupation>().Ignore("Id").HasKey(k => new { k.TalentBaseId, k.OccupationId });

            modelBuilder.Entity<TalentBase>()
                               .Property(p => p.HourPrice)
                               .HasColumnType("decimal(7,2)");
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var AddedEntities = ChangeTracker.Entries()
                                .Where(E => E.State == EntityState.Added)
                                .ToList();

            AddedEntities.ForEach(E =>
            {
                E.Property("CreatedAt").CurrentValue = DateTime.Now;
            });

            var EditedEntities = ChangeTracker.Entries()
                .Where(E => E.State == EntityState.Modified)
                .ToList();

            EditedEntities.ForEach(E =>
            {
                E.Property("UpdatedAt").CurrentValue = DateTime.Now;
            });

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public DbSet<Developer> Developer { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<TalentBase> TalentBase { get; set; }
        public DbSet<TalentBaseXKnowledge> TalentBaseXKnowledge { get; set; }
        public DbSet<TalentBaseXOccupation> TalentBaseXOccupation { get; set; }
    }
}
