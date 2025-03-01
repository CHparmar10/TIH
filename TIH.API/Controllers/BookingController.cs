using Microsoft.AspNetCore.Mvc;

namespace TIH.API.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
