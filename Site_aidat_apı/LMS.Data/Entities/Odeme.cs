using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Entities
{
    public class Odeme : BaseEntity
    {
        [Key] // Add this attribute to specify the primary key
        public int OdemeID { get; set; }
        public Guid KullaniciId { get; set; }
        public DateTime Tarih { get; set; }
        public int Tutar { get; set; }
        public User Kullanici { get; set; }
    }
}