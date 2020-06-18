using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirmaMvc.Models
{
    public partial class PI05Context : DbContext
    {
        public PI05Context(DbContextOptions<PI05Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CertifikatZaposlenik> CertifikatZaposlenik { get; set; }
        public virtual DbSet<Certifikati> Certifikati { get; set; }
        public virtual DbSet<KategorijaPoslova> KategorijaPoslova { get; set; }
        public virtual DbSet<KategorijaZaposlenik> KategorijaZaposlenik { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CertifikatZaposlenik>(entity =>
            {
                entity.ToTable("certifikat_zaposlenik");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CertifikatId).HasColumnName("certifikat_id");

                entity.Property(e => e.ZaposlenikId).HasColumnName("zaposlenik_id");

                entity.HasOne(d => d.Certifikat)
                    .WithMany(p => p.CertifikatZaposlenik)
                    .HasForeignKey(d => d.CertifikatId)
                    .HasConstraintName("FK_certifikat_zaposlenik_certifikati");
            });

            modelBuilder.Entity<Certifikati>(entity =>
            {
                entity.ToTable("certifikati");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Opis)
                    .HasColumnName("opis")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<KategorijaPoslova>(entity =>
            {
                entity.ToTable("kategorija_poslova");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<KategorijaZaposlenik>(entity =>
            {
                entity.ToTable("kategorija_zaposlenik");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KategorijaId).HasColumnName("kategorija_id");

                entity.Property(e => e.ZaposlenikId).HasColumnName("zaposlenik_id");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.KategorijaZaposlenik)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kategorija_zaposlenik_kategorija_poslova");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
