using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
	public class AddDbContext : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = tcp:novena.database.windows.net,1433; Initial Catalog = novena; Persist Security Info = False; User ID = novenaDb; Password =novena123.;Integrated Security=False;Encrypt=True; TrustServerCertificate = True;Trusted_Connection=False;");
		}
		public DbSet<AboutService> AboutServices { get; set; }
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Award> Awards { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Nurse> Nurses { get; set; }
		public DbSet<Radiolog> Radiologs { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }

	}
}
