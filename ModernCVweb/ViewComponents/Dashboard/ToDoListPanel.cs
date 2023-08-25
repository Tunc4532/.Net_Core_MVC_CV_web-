using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager setodolistManager = new ToDoListManager(new EfToDoListDal());

        public IViewComponentResult Invoke()
        {
            var values = setodolistManager.TGetList();
            return View(values);
        }
    }
}
