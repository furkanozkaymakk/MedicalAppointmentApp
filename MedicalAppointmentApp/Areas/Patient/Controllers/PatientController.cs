using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.Areas.Patient.Controllers
{
    public class PatientController : Controller
    {
        [Route("Patient/[controller]/[action]/{id?}")]
        [Route("Patient/[controller]/[action]/")]
        [Area("Patient")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
