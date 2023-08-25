using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        Context n = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = n.Portfolios.Count();
            ViewBag.v2 = n.Messages.Count();
            ViewBag.v3 = n.Services.Count();

            return View();
        }
    }
}
