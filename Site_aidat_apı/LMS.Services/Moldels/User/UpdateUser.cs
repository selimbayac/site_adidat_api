using LMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Moldels.User
{
    public class UpdateUser     
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TCNo { get; set; }
        public string? Telefon { get; set; }
        public string? PlakaNo { get; set; }
        public int RoleId { get; set; }
       
    }
}
