using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Moldels.Fatura
{
    public class FaturaRequestModel
    {
        public int DaireID { get; set; }

        [Range(1, 12, ErrorMessage = "Ay 1 ile 12 arasında olmalıdır.")]
        public int Ay { get; set; }

        [Range(1900, 2100, ErrorMessage = "Yıl 1900 ile 2100 arasında olmalıdır.")]
        public int Yil { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Elektrik Tutarı 0'dan büyük olmalıdır.")]
        public int ElektrikTutar { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Su Tutarı 0'dan büyük olmalıdır.")]
        public int SuTutar { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Doğalgaz Tutarı 0'dan büyük olmalıdır.")]
        public int DogalgazTutar { get; set; }
    }
    
}
