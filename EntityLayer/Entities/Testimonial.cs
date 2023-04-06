using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class Testimonial
	{
		[Key]
		public int Id { get; set; }
		public string userImage { get; set; }
		public string title { get; set; }
		public string comment { get; set; }
	}
}
