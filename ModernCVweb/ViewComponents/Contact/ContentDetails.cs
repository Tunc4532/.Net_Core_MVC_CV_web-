using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Contact
{
    public class ContentDetails : ViewComponent
    {
        ContactManager contactmanager = new ContactManager(new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var values = contactmanager.TGetList();
            return View(values);
        }

    }
}
