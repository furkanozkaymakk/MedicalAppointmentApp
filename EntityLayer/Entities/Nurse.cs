using CoreLayer.Entities;
namespace EntityLayer.Entities
{
	public class Nurse : EntityBase,IEntityBase
	{

		// F.K
		public int DoctorId { get; set; }
		public Doctor Doctor { get; set; }

	
	}
}
