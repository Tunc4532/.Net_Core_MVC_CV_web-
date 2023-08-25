using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModernCVweb.Areas.Writer.Models;

namespace ModernCVweb.Areas.Writer.Controllers
{

    [Area("Writer")]
    [Route("Writer/[controller]/[Action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _usermaManager;

        public RegisterController(UserManager<WriterUser> usermaManager)
        {
            _usermaManager = usermaManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {

            WriterUser w = new WriterUser()
            {
                Name = p.Name,
                Surname = p.SurName,
                Email = p.Mail,
                UserName = p.UserName,
                ImageUrl = p.ImageUrl,
            };

            if (p.ConfirmPassword == p.Password)
            {
                var result = await _usermaManager.CreateAsync(w, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
//yeni şifre
//Tunc12*/Cindas

//eski şifre
//tunnccase1aA*

//bu aynı
//452547