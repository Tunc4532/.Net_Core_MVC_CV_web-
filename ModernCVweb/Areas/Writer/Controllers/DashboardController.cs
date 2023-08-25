using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
       
        //dashboard kısmında sorun var buray kapatınsa sisteme yeniden tantike oldiğer menüler çalışıyor

        //public async Task< IActionResult> Index()
        //{
        //    //var values = await _userManager.FindByNameAsync(User.Identity.Name);
       
        //    //ViewBag.v = values.Name + " " + values.Surname;

        //    //statistics  --- solid biraz burada ezilicek

        //    //Context c = new Context();
        //    //ViewBag.v1 = c.mesWriterMessages.Where(x => x.Receiver == values.Email).Count();
        //    //ViewBag.v2 = c.annonccements.Count();
        //    //ViewBag.v3 = c.Users.Count();
        //    //ViewBag.v4 = c.Skills.Count();

        //    return View();
        //}
    }
}
//4KyJbwHfwDs94*T
