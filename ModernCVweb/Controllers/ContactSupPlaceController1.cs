using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    public class ContactSupPlaceController1 : Controller
    {
        ContactManager cocontactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = cocontactManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            cocontactManager.TUpdate(contact);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
