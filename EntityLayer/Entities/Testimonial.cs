using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
	public class Testimonial
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Comment { get; set; }

		//F.K
		public int AppUserId { get; set; }
		public AppUser AppUser { get; set; }
	}
}
