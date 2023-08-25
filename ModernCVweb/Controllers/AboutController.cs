using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class AboutController : Controller
    {
        AboutManager manabout = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = manabout.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About edabout)
        {
            manabout.TUpdate(edabout);
            return RedirectToAction("Index", "Default");
        }
    }
}
