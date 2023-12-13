﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Entities
{
    public class Aidat :BaseEntity
    {
        [Key] // Bu özniteliği ekleyerek birincil anahtarı belirtin
        public int AidatID { get; set; }
        public int DaireID { get; set; }
        [ForeignKey("DaireID")] // Bu özniteliği ekleyerek DaireID özelliği ile ilişkilendirin
        public Daire Daire { get; set; }
        public int Ay { get; set; }
        public int Yil { get; set; }
        public int Tutar { get; set; }
    }
}
