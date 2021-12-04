using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Models
{
    public class Tur
    {
        [Key]
        public int TurID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string TurAd { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
