using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]

    public class DefaultController : Controller
    {
        AnnonccementManager manannonuncement = new AnnonccementManager(new EfAnnouncumentDal());

        public IActionResult Index()
        {
            var values = manannonuncement.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AnnonccementDetails(int id)
        {
            var values = manannonuncement.TGetByID(id);
            return View(values);
        }

        public IActionResult LogOut()
        {
            //Sign methodu gelmiyor o yapılacak yoksa çıkış yap kısmı çalışmaz

            //await manannonuncement.SignOutAsync();
            return RedirectToAction("Index", "login");
        }
    }
}
