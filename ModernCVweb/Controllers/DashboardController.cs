using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
