using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.Areas.Writer.Controllers
{
    [Area("Writer")]
     [Route("Writer/Message")]

    public class MessageController : Controller
    {
        MesWriterManager admesWriterManager = new MesWriterManager(new EfMessWriterDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]

        public async Task< IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = admesWriterManager.GetListReceiverMessage(p);
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = admesWriterManager.GetListSenderMessage(p);
            return View(messageList);
        }
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            MesWriterMessage mesWriterMessage = admesWriterManager.TGetByID(id);
            return View(mesWriterMessage);
        }
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            MesWriterMessage mesWriterMessage = admesWriterManager.TGetByID(id);
            return View(mesWriterMessage);
        }
       

        //route eklenecek
        // 153 ile 155 arasındaki dersler izlenecek methot hatası var imzasının tanmlanması lazım

        // /////////////////  mesaj gönderme işlemi ///////////////////////////////////


        //[HttpGet]
        //public IActionResult SendMessage()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task < IActionResult> SendMessage(MesWriterManager p)
        //{
        //    var values = await _userManager.FindByNameAsync(User.Identity.Name);
        //    string mail = values.Email;
        //    string name = values.Name + " " + values.Surname;


        //    //admesWriterManager.TAdd(p);
        //    return RedirectToAction("SenderMessage", "Message");

        //}

    }
}
