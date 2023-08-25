using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager sosoocialMediaManager = new SocialMediaManager(new EfSocialMediaDal());

        public IActionResult Index()
        {
            var values = sosoocialMediaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.Status = true;
            sosoocialMediaManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = sosoocialMediaManager.TGetByID(id);
            sosoocialMediaManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = sosoocialMediaManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia p)
        {
            sosoocialMediaManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
