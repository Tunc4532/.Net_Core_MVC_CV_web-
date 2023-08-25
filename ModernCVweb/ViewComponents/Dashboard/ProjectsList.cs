using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Dashboard
{
    public class ProjectsList : ViewComponent
    {
        PortfolioManager seportolo = new PortfolioManager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = seportolo.TGetList();
            return View(values);
        }

    }
}
