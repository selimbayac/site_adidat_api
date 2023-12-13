using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Moldels.Odeme
{
    public class OdemeRequestModel
    {
        public int OdemeID { get; set; }
        public Guid KullaniciId { get; set; }
        public DateTime Tarih { get; set; }
        public int Tutar { get; set; }
   
    }
}
