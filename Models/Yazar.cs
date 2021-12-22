using System;
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

        [StringLength(30)]
        public string YazarAd { get; set; }
        public string YazarOzgecmis { get; set; }

        [StringLength(30)]
        public string YazarSoyad { get; set; }

        [StringLength(250)]
        public string YazarGorsel { get; set; }
        public ICollection<Kitap> Kitaps { get; set; }

    }
}
