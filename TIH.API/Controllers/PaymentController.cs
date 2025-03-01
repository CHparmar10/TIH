using Microsoft.AspNetCore.Mvc;

namespace TIH.API.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
