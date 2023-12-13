using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Moldels.Daire
{
    public class DaireRequestModel
    {
        public int DaireID { get; set; }

        [Required(ErrorMessage = "Blok alanı zorunludur.")]
        [StringLength(50, ErrorMessage = "Blok en fazla 50 karakter olmalıdır.")]
        public string Blok { get; set; }

        [Required(ErrorMessage = "Durumu alanı zorunludur.")]
        [StringLength(50, ErrorMessage = "Durumu en fazla 50 karakter olmalıdır.")]
        public string Durumu { get; set; }

        [Required(ErrorMessage = "Tipi alanı zorunludur.")]
        [StringLength(50, ErrorMessage = "Tipi en fazla 50 karakter olmalıdır.")]
        public string Tipi { get; set; }

        [Required(ErrorMessage = "Kat alanı zorunludur.")]
        public int Kat { get; set; }

        [Required(ErrorMessage = "Daire Numarası alanı zorunludur.")]
        public int DaireNumarasi { get; set; }

        [Required(ErrorMessage = "Sahip veya Kiracı alanı zorunludur.")]
        [StringLength(50, ErrorMessage = "Sahip veya Kiracı en fazla 50 karakter olmalıdır.")]
        public string SahipVeyaKiraci { get; set; }
    }
}
