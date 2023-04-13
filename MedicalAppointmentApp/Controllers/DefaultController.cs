using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstractions;

namespace MedicalAppointmentApp.Controllers
{
	public class DefaultController : Controller
	{
		private readonly IDoctorService _doctorService;

		public DefaultController(IDoctorService doctorService) {
			_doctorService = doctorService;
		}
		public async Task<IActionResult> Index()
		{
			var values = await _doctorService.TGetAllAsync();
			return View(values);
		}
	}
}
