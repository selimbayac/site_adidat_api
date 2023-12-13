using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Moldels.User
{
    public class UserRequestModel
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 6, ErrorMessage = "Şifre en az 6 ve en fazla 50 karakter olmalıdır.")]
        public string Password { get; set; }

        public int RoleId { get; set; } = 2;

        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string Telefon { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "TC Kimlik Numarası 11 karakter olmalıdır.")]
        public string TCNo { get; set; }

        [StringLength(10, ErrorMessage = "Plaka Numarası en fazla 10 karakter olmalıdır.")]
        public string PlakaNo { get; set; }
    }
}
