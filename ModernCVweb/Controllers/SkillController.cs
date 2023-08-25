using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class SkillController : Controller
    {
        //generic yapıya ulaşıyoruz
        SkıllManager manskıll = new SkıllManager(new EfSkillDal());


        //listeleme
        public IActionResult Index()
        {
            var values = manskıll.TGetList();
            return View(values);
        }


        //Ekleme 
        [HttpGet]
        public IActionResult AddSkııl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkııl(Skill adskıll)
        {
            manskıll.TAdd(adskıll);
            return RedirectToAction("Index");
        }


        //silme
        public IActionResult DeleteSkııl(int id)
        {
            var values =manskıll.TGetByID(id);
            manskıll.TDelete(values);
            return RedirectToAction("Index");
        }

        //güncelleme

        [HttpGet]
        public IActionResult EditSkııl(int id)
        {
            var values = manskıll.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkııl(Skill edskııl)
        {
            manskıll.TUpdate(edskııl);
            return RedirectToAction("Index");
        }
    }
}
