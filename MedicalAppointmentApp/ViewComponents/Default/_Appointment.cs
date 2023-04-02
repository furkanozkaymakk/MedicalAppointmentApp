using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.ViewComponents.Default
{
	public class _Appointment : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
