using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProjectApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Database
{
    public class ProjectDb : IdentityDbContext<ProjectUser>
    {
        public ProjectDb(DbContextOptions<ProjectDb> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Status>().HasData(
                new Status() { Id = 1, Description = "Afgewerkt" },
                new Status() { Id = 2, Description = "Huidig" },
                new Status() { Id = 3, Description = "Toekomstig" }
                );

            modelBuilder.Entity<Tag>().HasData(
                new Tag() { Id = 1, Description = "C#" },
                new Tag() { Id = 2, Description = "JavaScript" },
                new Tag() { Id = 3, Description = "CSS" },
                new Tag() { Id = 4, Description = "SQL" },
                new Tag() { Id = 5, Description = "Entity Framework" },
                new Tag() { Id = 6, Description = "HTML" },
                new Tag() { Id = 7, Description = "ASP.NET" }
                );

            modelBuilder.Entity<ProjectTag>().HasKey(pt => new { pt.TagId, pt.ProjectId });

            modelBuilder.Entity<ProjectTag>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.ProjectTags)
                .HasForeignKey(pt => pt.ProjectId);

            modelBuilder.Entity<ProjectTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.ProjectTags)
                .HasForeignKey(pt => pt.TagId);
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProjectTag> ProjectTags { get; set; }
    }
}
