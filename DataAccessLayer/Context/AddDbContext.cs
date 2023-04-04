using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class AddDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: SQL server'ı kendi serverName'ini bağla.
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-0PA7HPM\\SQLEXPRESS;Database=Novena;Trusted_Connection=True;TrustServerCertificate=True;");

        }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
