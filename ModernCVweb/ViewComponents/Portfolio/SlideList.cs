using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = portfoliomanager.TGetList();
            return View(values);

        }
    }
}
