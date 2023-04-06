using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccessLayer.Context
{
	public class AddDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = tcp:novena.database.windows.net,1433; Initial Catalog = novena; Persist Security Info = False; User ID = novenaDb; Password =novena123.;Integrated Security=False;Encrypt=True; TrustServerCertificate = True;Trusted_Connection=False;");
		}
		public DbSet<Award> Awards { get; set; }
		public DbSet<AboutService> AboutServices { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}
