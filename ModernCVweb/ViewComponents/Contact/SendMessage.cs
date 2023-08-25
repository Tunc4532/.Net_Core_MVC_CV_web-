using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager messagemanager = new MessageManager(new EfMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
           
            return View();
        }

        //alt kısımdaki alan fazla alan silme yinede 

        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date= Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messagemanager.TAdd(p);
        //    return View();
        //}

    }
}
