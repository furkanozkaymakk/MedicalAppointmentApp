using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
