using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class Award
	{
		[Key]
		public int Id { get; set; }
		public string name { get; set; }
		public string imageUrl { get; set; }
	}
}
