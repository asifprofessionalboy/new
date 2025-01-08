using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GFAS.Models
{
    public partial class GEOFENCEDBContext : DbContext
    {
        public GEOFENCEDBContext()
        {
        }

        public GEOFENCEDBContext(DbContextOptions<GEOFENCEDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppGeoFencing> AppGeoFencings { get; set; } = null!;
        public virtual DbSet<AppLocationMaster> AppLocationMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppGeoFencing>(entity =>
            {
                entity.ToTable("App_GeoFencing");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pno)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WorkSite)
                    .IsUnicode(false)
                    .HasColumnName("Work_Site");
            });

            modelBuilder.Entity<AppLocationMaster>(entity =>
            {
                entity.ToTable("App_LocationMaster");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(8, 6)");

                entity.Property(e => e.Range)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkSite)
                    .IsUnicode(false)
                    .HasColumnName("Work_Site");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
