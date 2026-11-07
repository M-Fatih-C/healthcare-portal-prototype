using Microsoft.AspNetCore.Mvc;

namespace panel_new.PresentationLayer.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult DoctorPanel()
        {
            return View();
        }
    }
}
