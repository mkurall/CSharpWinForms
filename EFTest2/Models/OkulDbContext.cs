using Microsoft.EntityFrameworkCore;

namespace EFTest2.Models
{
    public class OkulDbContext : DbContext
    {
        public OkulDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=btk_okul_db;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sinif>()
                .Property(x => x.Seviye)
                .IsRequired(false);

            modelBuilder.Entity<Sinif>()
                .Property(x => x.Ad)
                .HasMaxLength(15);

            modelBuilder.Entity<Sinif>()
                .HasMany(e => e.Ogrenciler)
                .WithOne(e => e.Sinifi)
                
                .IsRequired(false);

            modelBuilder.Entity<Ogrenci>()
                .HasMany(e => e.Klupler)
                .WithMany(e => e.Ogrenciler);
        }

        public virtual DbSet<Sinif> Siniflar { get; set; }

        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Klup> Klupler { get; set; }
    }
}

//Add-Migration IlkVersiyon
//Update-Database