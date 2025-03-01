using Microsoft.AspNetCore.Mvc;

namespace TIH.API.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
