using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Entities
{
	public class AppUser : IdentityUser<int>
	{
		public string FullName { get; set; }
		public string ImageUrl { get; set; }
		public string TelNo { get; set; }
		public string Gender { get; set; }
		public string PatientStory { get; set; }

		
		//F.K
		
		public int DoctorId { get; set; }
		public Doctor Doctor { get; set; }

		public int RadiologId { get; set; }
		public Radiolog Radiolog { get; set; }


		public List<Appointment> Appointments { get; set; }
		public List<Testimonial> Testimonials { get; set; }
	}
}
