using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ModernCVweb.Controllers
{
    public class Eperience2Controller : Controller
    {
        ExperienceManager exxexperienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ListEperience()
        {
            var values = JsonConvert.SerializeObject(exxexperienceManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddEperience(Experience p)
        {
            exxexperienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int ExperienceID)
        {
            var v = exxexperienceManager.TGetByID(ExperienceID);  
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var v = exxexperienceManager.TGetByID(id);
            exxexperienceManager.TDelete(v);
            return NoContent();

        }
    }
}
