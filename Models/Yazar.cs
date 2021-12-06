﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Models
{
    public class Yazar
    {
        [Key]
        public int YazarId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string YazarAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string YazarSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string YazarGorsel { get; set; }
        public ICollection<Kitap> Kitaps { get; set; }

    }
}
