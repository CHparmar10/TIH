using Microsoft.AspNetCore.Mvc;

namespace TIH.API.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
