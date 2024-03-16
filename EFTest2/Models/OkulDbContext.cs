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

        public virtual DbSet<Sinif> Siniflar { get; set; }
    }
}
    //Add-Migration IlkVersiyon
    //Update-Database