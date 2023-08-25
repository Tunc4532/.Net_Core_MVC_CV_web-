using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        SocialMediaManager sosocialMediaManager = new SocialMediaManager(new EfSocialMediaDal());

        public IViewComponentResult Invoke()
        {
            var values = sosocialMediaManager.TGetList();
            return View(values);
        }
    }
}
