using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.DAL.Entities;

namespace Tracker.DAL
{
    public class TrackerDbContext : DbContext
    {
        public TrackerDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Bug 
            modelBuilder.Entity<Bug>()
                .Property(e => e.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Bug>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            #endregion

            #region Project 
            modelBuilder.Entity<Project>()
                .Property(e => e.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Project>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            #endregion

            #region Tag 
            modelBuilder.Entity<Tag>()
                .Property(e => e.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Tag>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            #endregion

            #region User 
            modelBuilder.Entity<User>()
                .Property(e => e.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<User>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            #endregion

            #region Comment 
            modelBuilder.Entity<Comment>()
                .Property(e => e.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Comment>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            #endregion

            modelBuilder.Entity<User>()
                .HasIndex(e => e.Username)
                .IsUnique();

            modelBuilder.Entity<Bug>()
                .HasMany(e => e.Assignees)
                .WithMany(e => e.AssignedBugs)
                .UsingEntity(e => e.ToTable("BugAssignee"));

            modelBuilder.Entity<Bug>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.TaggedBugs)
                .UsingEntity(e => e.ToTable("BugTag"));

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Members)
                .WithMany(e => e.Projects)
                .UsingEntity(e => e.ToTable("ProjectMember"));

            modelBuilder.Entity<Bug>()
                .HasOne(e => e.Author)
                .WithMany()
                .HasForeignKey("AuthorId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Bug>()
                .HasOne(e => e.Project)
                .WithMany()
                .HasForeignKey("ProjectId");

            modelBuilder.Entity<Bug>()
                .HasMany(e => e.Comments)
                .WithOne()
                .HasForeignKey("BugId");

            modelBuilder.Entity<Comment>()
                .HasOne(e => e.Author)
                .WithMany()
                .HasForeignKey("AuthorId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Project>()
                .HasOne(e => e.Owner)
                .WithMany()
                .HasForeignKey("OwnerId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
