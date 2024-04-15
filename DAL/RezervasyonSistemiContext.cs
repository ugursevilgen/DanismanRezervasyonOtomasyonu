using System;
using System.Collections.Generic;
using DanismanRezervasyonOtomasyonu.Models;
using Microsoft.EntityFrameworkCore;

namespace DanismanRezervasyonOtomasyonu.DAL;

public partial class RezervasyonSistemiContext : DbContext
{
    public RezervasyonSistemiContext()
    {
    }

    public RezervasyonSistemiContext(DbContextOptions<RezervasyonSistemiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Danisan> Danisans { get; set; }

    public virtual DbSet<Danisman> Danismen { get; set; }

    public virtual DbSet<Rezervasyon> Rezervasyons { get; set; }

    public virtual DbSet<Yonetici> Yoneticis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=UGURSEVILGEN\\SQLEXPRESS;Database=RezervasyonSistemi;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Danisan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Danışan");

            entity.ToTable("Danisan");

            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.Adres).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(8);
            entity.Property(e => e.Soyad).HasMaxLength(50);
            entity.Property(e => e.Telefon).HasMaxLength(11);
            entity.Property(e => e.TestGds)
                .HasMaxLength(50)
                .HasColumnName("Test_GDS");
            entity.Property(e => e.TestMmse)
                .HasMaxLength(50)
                .HasColumnName("Test_MMSE");
            entity.Property(e => e.TestMoCa)
                .HasMaxLength(50)
                .HasColumnName("Test_MoCA");
        });

        modelBuilder.Entity<Danisman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Danışman");

            entity.ToTable("Danisman");

            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Soyad).HasMaxLength(50);
            entity.Property(e => e.Telefon).HasMaxLength(11);
        });

        modelBuilder.Entity<Rezervasyon>(entity =>
        {
            entity.ToTable("Rezervasyon");

            entity.Property(e => e.Odeme).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Yonetici>(entity =>
        {
            entity.ToTable("Yonetici");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(8);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
