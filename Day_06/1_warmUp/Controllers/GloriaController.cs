using Microsoft.AspNetCore.Mvc;

namespace _1_warmUp.Controllers
{
    public class GloriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            return View();
        }
    }
}