using Microsoft.AspNetCore.Mvc;

namespace TIH.API.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
