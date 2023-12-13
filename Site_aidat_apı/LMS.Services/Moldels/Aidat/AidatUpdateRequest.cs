using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Moldels.Aidat
{
    public class AidatUpdateRequest
    {
        public int AidatID { get; set; }
        public int DaireID { get; set; }
        public int Ay { get; set; }
        public int Yil { get; set; }
        public int Tutar { get; set; }
    }
}
