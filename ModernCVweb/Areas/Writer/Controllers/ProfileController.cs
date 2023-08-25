using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModernCVweb.Areas.Writer.Models;

namespace ModernCVweb.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[Action]")]

    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel omodel = new UserEditViewModel();
            omodel.Name = values.Name;
            omodel.Surname = values.Surname;
            omodel.PictureUrl = values.ImageUrl;

            return View(omodel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var deger = await _userManager.FindByNameAsync(User.Identity.Name);

            if(p.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imaename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimage/" + imaename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                deger.ImageUrl = imaename;
            }

            deger.Name = p.Name;
            deger.Surname = p.Surname;
            deger.PasswordHash = _userManager.PasswordHasher.HashPassword(deger , p.Password);


            var result = await _userManager.UpdateAsync(deger);

            if(result.Succeeded)
            {
                return RedirectToAction("Index", "login");
            }

            return View();
        }
    }
}
