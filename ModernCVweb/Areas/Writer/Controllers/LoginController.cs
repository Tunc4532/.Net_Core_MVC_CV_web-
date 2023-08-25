using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModernCVweb.Areas.Writer.Models;

namespace ModernCVweb.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[Action]")]

    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInmanager;

        public LoginController(SignInManager<WriterUser> signInmanager)
        {
            _signInmanager = signInmanager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Index (UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInmanager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Profile");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }
            return View();
        }
    }
}
