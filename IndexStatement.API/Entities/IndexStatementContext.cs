using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace IndexStatement.API.Entities
{
    public partial class IndexStatementContext : DbContext
    {
        public IndexStatementContext()
        {
        }

        public IndexStatementContext(DbContextOptions<IndexStatementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EnergyType> EnergyTypes { get; set; }
        public virtual DbSet<Statement> Statements { get; set; }
        public virtual DbSet<StatementValue> StatementValues { get; set; }
        public virtual DbSet<Unity> Unities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<EnergyType>(entity =>
            {
                entity.ToTable("EnergyType");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Statement>(entity =>
            {
                entity.ToTable("Statement");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.EnergyType)
                    .WithMany(p => p.Statements)
                    .HasForeignKey(d => d.EnergyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Statement_EnergyType");

                entity.HasOne(d => d.StatementValue)
                    .WithMany(p => p.Statements)
                    .HasForeignKey(d => d.StatementValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Statement_StatementValue");
            });

            modelBuilder.Entity<StatementValue>(entity =>
            {
                entity.ToTable("StatementValue");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Unity)
                    .WithMany(p => p.StatementValues)
                    .HasForeignKey(d => d.UnityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatementValue_Unity");
            });

            modelBuilder.Entity<Unity>(entity =>
            {
                entity.ToTable("Unity");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
