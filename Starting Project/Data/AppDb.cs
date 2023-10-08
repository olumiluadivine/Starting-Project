using Microsoft.EntityFrameworkCore;
using Starting_Project.Models;

namespace Starting_Project.Data
{
    public class AppDb : DbContext
    {
        public DbSet<ProgramDetailsModel> ProgramDetails { get; set; }

        public DbSet<ApplicationForm> ApplicationForms { get; set; }

        public DbSet<Workflow> Workflows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseCosmos(
                "https://cosmosrgeastusc07e338d-1ec7-45c5-b71adb.documents.azure.com:443/",
                "0i585XNVf36BWOdDacPat8ewiICTlFoUcZHBtelYsHuezAPDXcT2glyu6tQM3l2VFLOV4msW3GjwACDbse1O8w==",
                "Starting-Project");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgramDetailsModel>()
                    .ToContainer("ProgramDetails") // ToContainer
                    .HasPartitionKey(e => e.Id); // Partition Key

            modelBuilder.Entity<ApplicationForm>()
                .ToContainer("Application") // ToContainer
                .HasPartitionKey(c => c.Id); // Partition Key

            modelBuilder.Entity<Workflow>()
                .ToContainer("Workflow") // ToContainer
                .HasPartitionKey(c => c.Id); // Partition Key
        }
    }
}
