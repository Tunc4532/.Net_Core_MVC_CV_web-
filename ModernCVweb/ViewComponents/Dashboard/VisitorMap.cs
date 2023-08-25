using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
