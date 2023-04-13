using System.ComponentModel.DataAnnotations;

namespace CoreLayer.Entities
{
	public class EntityBase : IEntityBase
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public string Ozet { get; set; }
		public string Educations { get; set; }
		public string FacebookUrl { get; set; }
		public string TwitterUrl { get; set; }
		public string LinkedinUrl { get; set; }
	}
}
