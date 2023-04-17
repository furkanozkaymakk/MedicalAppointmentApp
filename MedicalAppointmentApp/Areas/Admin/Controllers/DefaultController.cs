using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Areas.Admin.Controllers
{
	public class DefaultController : Controller
	{
		[Route("Admin/[controller]/[action]/{id?}")]
		[Route("Admin/[controller]/[action]/")]
		[Area("Admin")]
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
	}
}
