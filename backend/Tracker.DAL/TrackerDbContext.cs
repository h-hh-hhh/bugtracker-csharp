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
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Bug Add Cluster Id
            modelBuilder.Entity<Bug>()
                .Property(e => e.Id)
                .HasDefaultValue(Guid.NewGuid());
            modelBuilder.Entity<Bug>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            modelBuilder.Entity<Bug>()
                .HasKey(e => e.ClusterId)
                .IsClustered();
            #endregion

            #region Project Add Cluster Id
            modelBuilder.Entity<Project>()
                .Property(e => e.Id)
                .HasDefaultValue(Guid.NewGuid());
            modelBuilder.Entity<Project>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            modelBuilder.Entity<Project>()
                .HasKey(e => e.ClusterId)
                .IsClustered();
            #endregion

            #region Tag Add Cluster Id
            modelBuilder.Entity<Tag>()
                .Property(e => e.Id)
                .HasDefaultValue(Guid.NewGuid());
            modelBuilder.Entity<Tag>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            modelBuilder.Entity<Tag>()
                .HasKey(e => e.ClusterId)
                .IsClustered();
            #endregion

            #region User Add Cluster Id
            modelBuilder.Entity<User>()
                .Property(e => e.Id)
                .HasDefaultValue(Guid.NewGuid());
            modelBuilder.Entity<User>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            modelBuilder.Entity<User>()
                .HasKey(e => e.ClusterId)
                .IsClustered();
            #endregion

            #region Comment Add Cluster Id
            modelBuilder.Entity<Comment>()
                .Property(e => e.Id)
                .HasDefaultValue(Guid.NewGuid());
            modelBuilder.Entity<Comment>()
                .HasKey(e => e.Id)
                .IsClustered(false);
            modelBuilder.Entity<Comment>()
                .HasKey(e => e.ClusterId)
                .IsClustered();
            #endregion

            modelBuilder.Entity<User>()
                .HasIndex(e => e.Username)
                .IsUnique();
        }
    }
}
