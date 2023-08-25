using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Dashboard
{
    public class AdminNavMessageList : ViewComponent
    {
        //MesWriterManager wrwwriterManager = new MesWriterManager(new EfMessWriterDal());
        MessageManager wemessageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
          //  var p = "tunccindas7570@gmail.com";

            var values = wemessageManager.TGetList().OrderByDescending(x=>x.MessageID).Take(3).ToList();
            //var values = wrwwriterManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
            return View(values);
        }

    }
}
