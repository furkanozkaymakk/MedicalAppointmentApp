using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
