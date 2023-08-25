using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager manportfolio = new PortfolioManager(new EfPortfolioDal());

        public IActionResult Index()
        {
            var values = manportfolio.TGetList();
            return View(values);
        }

        //Ekleme 
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio adportfolio)
        {
            manportfolio.TAdd(adportfolio);
            return RedirectToAction("Index");
        }


        //silme
        public IActionResult DeletePortfolio(int id)
        {
            var values = manportfolio.TGetByID(id);
            manportfolio.TDelete(values);
            return RedirectToAction("Index");
        }

        //güncelleme

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = manportfolio.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio edportfollio)
        {
            manportfolio.TUpdate(edportfollio);
            return RedirectToAction("Index");
        }
    }
}
