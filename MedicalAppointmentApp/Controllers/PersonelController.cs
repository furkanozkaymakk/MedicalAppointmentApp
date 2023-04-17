using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstractions;

namespace MedicalAppointmentApp.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IDoctorService doctorService;

        public PersonelController(IDoctorService doctorService)
        {
            this.doctorService = doctorService;
        }
        public async Task<IActionResult> Index()
        {
            var doctors = doctorService.TGetAllAsync();
            return View(doctors);
        }
        //TODO: Hepsini tek sayfada nasıl gösterecez razorda? 
    }
}
