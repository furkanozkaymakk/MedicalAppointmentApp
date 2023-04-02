using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.ViewComponents.Default
{
	public class _Feature : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
