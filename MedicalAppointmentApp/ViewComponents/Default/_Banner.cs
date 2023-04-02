using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.ViewComponents.Default
{
	public class _Banner : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
