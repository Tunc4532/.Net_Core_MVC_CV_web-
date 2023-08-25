using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnonccementManager annonccementManager = new AnnonccementManager(new EfAnnouncumentDal());

        public IViewComponentResult Invoke()
        {
            var values = annonccementManager.TGetList();
            return View(values);

        }
    }
}
