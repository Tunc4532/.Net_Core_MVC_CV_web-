using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Skıll
{
    public class SkıllList : ViewComponent
    {
        SkıllManager skıllmanager = new SkıllManager(new EfSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = skıllmanager.TGetList();
            return View(values);
        }
    }
}
