using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.ViewComponents.About
{
    public class _About : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
