using Microsoft.EntityFrameworkCore;
using ScientificLaboratory.Models;

namespace ScientificLaboratory.Data
{
    public class LaboratoryContext : DbContext
    {
        public LaboratoryContext(DbContextOptions<LaboratoryContext> options)
            : base(options)
        {
        }

        public DbSet<Researcher> Researchers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Equipment> Equipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка связей между сущностями
            modelBuilder.Entity<Project>()
                .HasOne<Researcher>()
                .WithMany()
                .HasForeignKey(p => p.LeadResearcherId);

            modelBuilder.Entity<Equipment>()
                .HasOne<Project>()
                .WithMany()
                .HasForeignKey(e => e.ProjectId);
        }
    }
}