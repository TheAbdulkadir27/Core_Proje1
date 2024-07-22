using System.ComponentModel.DataAnnotations;

namespace Core_Proje1.Areas.Author.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "lütfen name giriniz")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "lütfen surname giriniz")]
        public string Surname { get; set; } = string.Empty;

        [Required(ErrorMessage = "lütfen username giriniz")]
        public string UserName { get; set; } = string.Empty;

        [Compare("ConfirmPassword",ErrorMessage ="Şifreler uyuşmuyor")]
        [Required(ErrorMessage = "lütfen şifre giriniz")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "lütfen şifreyi onaylayınız")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "lütfen mail  giriniz")]
        public string Mail { get; set; } = string.Empty;

        [Required(ErrorMessage = "lütfen görsel yolu giriniz")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
