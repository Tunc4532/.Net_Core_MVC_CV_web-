using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{
    // [AllowAnonyuomus]

    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message pe)
        {
            MessageManager messagemanager = new MessageManager(new EfMessageDal());
            pe.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            pe.Status = true;
            messagemanager.TAdd(pe);
            return PartialView();
        }
        
    }  
}
