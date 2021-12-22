using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Models
{
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }

        [StringLength(50)]
        public string KitapAdi { get; set; }
        public string KitapTanıtım { get; set; } //Kitap içerigi tanıtımı

        [StringLength(250)]
        public string KitapGorsel { get; set; }
        public int KitapSayfa { get;  set; }
        public int KitapPuan { get; set; }
        
        // Kitabin Yazar ile iliskisi
        public int YazarId { get; set; }
        public virtual Yazar Yazar { get; set; }
        
        //Kitabin turle iliskisi
        public int TurId { get; set; }
        
        public virtual Tur Tur { get; set; }

    }
}
