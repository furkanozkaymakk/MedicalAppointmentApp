using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Appointment
	{
		[Key]
		public int Id { get; set; }
		public DateTime DateTime { get; set; }
		public DateTime DateHours { get; set; }
		public string Descripton { get; set; }

		// F.K
		public int AppUserId { get; set; }
		public AppUser AppUser { get; set; }

	}
}
