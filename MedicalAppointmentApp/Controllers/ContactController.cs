using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
