using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GFAS.Models
{
    public partial class UserLoginDBContext : DbContext
    {
        public UserLoginDBContext()
        {
        }

        public UserLoginDBContext(DbContextOptions<UserLoginDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppEmployeeMaster> AppEmployeeMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.Entity<AppEmployeeMaster>(entity =>
            {
                entity.ToTable("App_EmployeeMaster");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Bg)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("BG");

                entity.Property(e => e.ContinuityOfService)
                    .HasColumnType("datetime")
                    .HasColumnName("Continuity_of_service");

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfEmpl).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Designation).IsUnicode(false);

                entity.Property(e => e.DischargeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Discharge_Date");

                entity.Property(e => e.DivisionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Intime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Level)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManualFromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Manual_FromDate");

                entity.Property(e => e.ManualToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Manual_ToDate");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OffDay1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OffDay2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Outtime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pno)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingPno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ReportingPNO");

                entity.Property(e => e.SaturdayHalf).HasColumnName("Saturday_Half");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SuspentionFromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Suspention_FromDate");

                entity.Property(e => e.SuspentionTodate)
                    .HasColumnType("datetime")
                    .HasColumnName("Suspention_Todate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
