﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
                new Status() { Id = 1, Description = "Finished" },
                new Status() { Id = 2, Description = "Current" },
                new Status() { Id = 3, Description = "Future" }
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

            //testdata

            modelBuilder.Entity<Project>().HasData(
                new Project() { Id = 1, Title = "Calculator", StatusId = 1, CompletionDate = DateTime.Now, Description = "Fun winforms project" },
                new Project() { Id = 2, Title = "Portfolio website", StatusId = 2, CompletionDate = DateTime.Now, Description = "Difficult project" }
                );

            modelBuilder.Entity<ProjectTag>().HasData(
new ProjectTag() { ProjectId = 1, TagId = 1 },
new ProjectTag() { ProjectId = 1, TagId = 2 },
new ProjectTag() { ProjectId = 2, TagId = 5 },
new ProjectTag() { ProjectId = 2, TagId = 7 }
);


        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProjectTag> ProjectTags { get; set; }
    }
}
