using Microsoft.AspNetCore.Mvc;
namespace panel_new.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
