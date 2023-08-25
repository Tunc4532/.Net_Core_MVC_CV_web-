using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Dashboard
{
    public class Message2Listt : ViewComponent
    {
        //UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IViewComponentResult Invoke()
        {
            //var values = messageManager.GetUserMessagesWithUserService();
            var values = messageManager.TGetList().Take(4).ToList();
            return View(values);
        }
    }
}
