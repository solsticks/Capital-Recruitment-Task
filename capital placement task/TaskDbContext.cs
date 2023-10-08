using capital_placement_task.DTOs;
using capital_placement_task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital_placement_task
{
    public class TaskDbContext : DbContext
    {
        public DbSet<ProgramDetails>? ProgramDetails { get; set; }
        public DbSet<ApplicationForm>? ApplicationForms { get; set; }
        public DbSet<WorkFlow>? WorkFlows { get; set; }
        public DbSet<Preview>? Previews { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                "https://localhost:8081",
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                "PlacementTask-db"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgramDetails>()
                .ToContainer("ProgramDetails")
                .HasPartitionKey(c => c.Id);

            modelBuilder.Entity<ApplicationForm>()
                .ToContainer("ApplicationForm")
                .HasPartitionKey(e => e.Id);

            modelBuilder.Entity<WorkFlow>()
                .ToContainer("WorkFlow")
                .HasPartitionKey(s => s.Id);

            modelBuilder.Entity<Preview>()
               .ToContainer("Previews")
               .HasPartitionKey(p => p.Id);

            modelBuilder.Entity<ProgramDetails>().OwnsOne(p => p.AdditionalInfo);
           
            modelBuilder.Entity<ApplicationForm>().OwnsOne(a => a.PersonalInfo);
            modelBuilder.Entity<ApplicationForm>().OwnsOne(b => b.Profiles);
            modelBuilder.Entity<ApplicationForm>().OwnsOne(c => c.AdditionalQuestions);

            modelBuilder.Entity<WorkFlow>().OwnsOne(a => a.VideoInterview);

        }
    }
}
