using CrudNetAngular.Core.Models;
using CrudNetAngular.Data.Initial_Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;

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
        }

        public DbSet<Developer> Developer { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<TalentBase> TalentBase { get; set; }
        public DbSet<TalentBaseXKnowledge> TalentBaseXKnowledge { get; set; }
        public DbSet<TalentBaseXOccupation> TalentBaseXOccupation { get; set; }
    }
}
