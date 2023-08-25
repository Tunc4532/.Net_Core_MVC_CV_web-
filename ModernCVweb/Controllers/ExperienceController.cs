using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    //[Authorize(Roles ="Admin")]
    // [Authorize] 555555aA*     666666aA* deneme
    public class ExperienceController : Controller
    {
        ExperienceManager manexperience = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            var values = manexperience.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience adexperience)
        {
            manexperience.TAdd(adexperience);
            return RedirectToAction("Index");
        }

        //silme
        public IActionResult DeleteExperience(int id)
        {
            var values = manexperience.TGetByID(id);
            manexperience.TDelete(values);
            return RedirectToAction("Index");
        }

        //güncelleme

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = manexperience.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience edexperience)
        {
            manexperience.TUpdate(edexperience);
            return RedirectToAction("Index");
        }
    }
}
