using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Controllers
{

    public class TMessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteTMessage(int id)
        {
            var values = messageManager.TGetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult ShowTMessage(int id)
        {
            var values = messageManager.TGetByID(id);
            return View(values);
        }
    }
}
