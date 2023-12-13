using System.ComponentModel.DataAnnotations;

namespace Site_aidat_apı.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [StringLength(50, ErrorMessage = "E-posta en fazla 50 karakter olmalıdır.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        public string Password { get; set; }
    }
}
