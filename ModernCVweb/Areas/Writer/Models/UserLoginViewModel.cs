using System.ComponentModel.DataAnnotations;

namespace ModernCVweb.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen adınızı girin...!")]
        public string UserName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi girin...!")]
        public string Password { get; set; }
    }
}
