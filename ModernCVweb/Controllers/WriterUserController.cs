using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ModernCVweb.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager wwriterUserManager = new WriterUserManager(new EfWriterUserDal());

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(wwriterUserManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(WriterUser p)
        {
            wwriterUserManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

    }
}
