using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
