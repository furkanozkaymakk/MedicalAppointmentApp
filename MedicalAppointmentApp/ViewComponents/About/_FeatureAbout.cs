using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentApp.ViewComponents.About
{
    public class _FeatureAbout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
