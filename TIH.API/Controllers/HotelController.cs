using Microsoft.AspNetCore.Mvc;

namespace TIH.API.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
