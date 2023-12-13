using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Entities
{
    public class User:BaseEntity
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TCNo { get; set; }
        public string? Telefon { get; set; }
        public string? PlakaNo { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Odeme> Odemeler { get; set; } = new List<Odeme>();
    }
}
