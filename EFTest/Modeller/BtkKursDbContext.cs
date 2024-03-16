using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFTest.Modeller;

public partial class BtkKursDbContext : DbContext
{
    public BtkKursDbContext()
    {
    }

    public BtkKursDbContext(DbContextOptions<BtkKursDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblKullanicilar> TblKullanicilars { get; set; }

    public virtual DbSet<TblKursKatilim> TblKursKatilims { get; set; }

    public virtual DbSet<TblKursiyerler> TblKursiyerlers { get; set; }

    public virtual DbSet<TblKurslar> TblKurslars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=btk_kurs_db;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblKullanicilar>(entity =>
        {
            entity.ToTable("TblKullanicilar");

            entity.Property(e => e.Ad).HasMaxLength(20);
            entity.Property(e => e.Eposta)
                .HasMaxLength(50)
                .HasColumnName("EPosta");
            entity.Property(e => e.Parola).HasMaxLength(50);
            entity.Property(e => e.Soyad).HasMaxLength(20);
        });

        modelBuilder.Entity<TblKursKatilim>(entity =>
        {
            entity.ToTable("TblKursKatilim");

            entity.HasOne(d => d.Kurs).WithMany(p => p.TblKursKatilims)
                .HasForeignKey(d => d.KursId)
                .HasConstraintName("FK_TblKursKatilim_TblKurslar");

            entity.HasOne(d => d.Kursiyer).WithMany(p => p.TblKursKatilims)
                .HasForeignKey(d => d.KursiyerId)
                .HasConstraintName("FK_TblKursKatilim_TblKursiyerler");
        });

        modelBuilder.Entity<TblKursiyerler>(entity =>
        {
            entity.ToTable("TblKursiyerler");

            entity.Property(e => e.Ad).HasMaxLength(20);
            entity.Property(e => e.Eposta)
                .HasMaxLength(50)
                .HasColumnName("EPosta");
            entity.Property(e => e.Soyad).HasMaxLength(20);
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblKurslar>(entity =>
        {
            entity.ToTable("TblKurslar");

            entity.Property(e => e.EgitmenBilgisi).HasMaxLength(30);
            entity.Property(e => e.KursAdi).HasMaxLength(100);
            entity.Property(e => e.KursTarihi).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
