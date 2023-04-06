using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class AboutService
	{
		[Key]
		public int Id { get; set; }
		public string title { get; set; }
		public string description { get; set; }
	}
}
