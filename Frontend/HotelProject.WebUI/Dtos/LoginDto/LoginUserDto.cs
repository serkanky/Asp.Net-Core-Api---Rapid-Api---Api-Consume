using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adını Yazınız!!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre Yazınız!!")]
        public string Password { get; set; }
    }
}
