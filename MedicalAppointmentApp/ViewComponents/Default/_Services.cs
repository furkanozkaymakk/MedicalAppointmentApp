using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.ViewComponents.Default
{
	public class _Services : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
