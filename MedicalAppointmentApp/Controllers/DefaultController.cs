using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstractions;

namespace MedicalAppointmentApp.Controllers
{
    public class DefaultController : Controller
    {

        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
