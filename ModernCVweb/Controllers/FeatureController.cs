using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager manfeature = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {       
            var values = manfeature.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature edfeature)
        {
            manfeature.TUpdate(edfeature);
            return RedirectToAction("Index","Default");
        }
    }
}
