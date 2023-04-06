using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class Service
	{
		[Key]
		public int Id { get; set; }
		public string imageUrl { get; set; }
		public string title { get; set; }
		public string ozet { get; set; }
		public string subtitle { get; set; }
		public string description { get; set; }
	}
}
