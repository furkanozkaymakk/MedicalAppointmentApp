using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
