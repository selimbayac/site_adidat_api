using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Entities
{
    public class Daire :BaseEntity
    {
        [Key]
        public int DaireID { get; set; }
        public string Blok { get; set; }
        public string Durumu { get; set; }
        public string Tipi { get; set; }
        public int Kat { get; set; }
        public int DaireNumarasi { get; set; }
        public string SahipVeyaKiraci { get; set; }
        public List<Aidat> Aidatlar { get; set; }
        public List<Fatura> Faturalar { get; set; }
    }
}
