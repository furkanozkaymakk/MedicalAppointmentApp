using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.ViewComponents.Default
{
	public class _SectionAbout : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
