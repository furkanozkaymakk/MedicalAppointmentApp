using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.ViewComponents.Default
{
	public class _Statistics : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
