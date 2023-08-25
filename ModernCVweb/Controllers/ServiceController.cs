using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager manservice = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            var values = manservice.TGetList();
            return View(values);
        }

        //Ekleme 
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service adservice)
        {
            manservice.TAdd(adservice);
            return RedirectToAction("Index");
        }


        //silme
        public IActionResult DeleteService(int id)
        {
            var values = manservice.TGetByID(id);
            manservice.TDelete(values);
            return RedirectToAction("Index");
        }

        //güncelleme

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = manservice.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service edservice)
        {
            manservice.TUpdate(edservice);
            return RedirectToAction("Index");
        }

    }
}
