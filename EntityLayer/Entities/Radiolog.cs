using CoreLayer.Entities;

namespace EntityLayer.Entities
{
	public class Radiolog : EntityBase,IEntityBase
	{
		public List<AppUser> AppUsers { get; set; }
	}
}
