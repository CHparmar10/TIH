using Microsoft.AspNetCore.Mvc;

namespace TIH.API.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
