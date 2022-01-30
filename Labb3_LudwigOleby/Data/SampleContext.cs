using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb3_LudwigOleby.Models
{
    public partial class SampleContext : DbContext
    {
        public SampleContext()
        {
        }

        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBetyg> TblBetyg { get; set; }
        public virtual DbSet<TblElever> TblElever { get; set; }
        public virtual DbSet<TblPersonal> TblPersonal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data source = SPELDATOR; Initial Catalog = Labb2_Skola; Integrated Security = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBetyg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBetyg");

                entity.Property(e => e.BetygsDatum).HasColumnType("date");

                entity.Property(e => e.Kurs)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Slutbetyg)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Betyg)
                    .WithMany()
                    .HasForeignKey(d => d.BetygId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBetyg_tblElever");

                entity.HasOne(d => d.Lärar)
                    .WithMany()
                    .HasForeignKey(d => d.LärarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBetyg_tblPersonal");
            });

            modelBuilder.Entity<TblElever>(entity =>
            {
                entity.HasKey(e => e.ElevId)
                    .HasName("PK__tblEleve__4AE80D6339D69BD2");

                entity.ToTable("tblElever");

                entity.Property(e => e.ElevId).ValueGeneratedNever();

                entity.Property(e => e.EfterNamn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FörNamn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Klass).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPersonal>(entity =>
            {
                entity.HasKey(e => e.PersonalId)
                    .HasName("PK__tblPerso__283437F3E05594B8");

                entity.ToTable("tblPersonal");

                entity.Property(e => e.PersonalId).ValueGeneratedNever();

                entity.Property(e => e.EfterNamn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FörNamn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Roll)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
