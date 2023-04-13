using CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityLayer.Entities
{
	public class Doctor : EntityBase, IEntityBase
	{
		public List<AppUser> AppUsers { get; set; }
		public List<Nurse> Nurses { get; set; }
	}

}
