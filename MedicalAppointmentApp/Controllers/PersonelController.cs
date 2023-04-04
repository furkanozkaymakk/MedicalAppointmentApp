using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
