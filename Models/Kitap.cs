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

        [StringLength(40)]
        public int KitapAdi { get; set; }

        [StringLength(250)]
        public string KitapGorsel { get; set; }
        public int KitapPuan { get; set; }
        
        // Kitabin Yazar ile iliskisi
        public int YazarId { get; set; }
        public Yazar KYazar { get; set; }
        
        //Kitabin turle iliskisi
        public int TurId { get; set; }
        
        public Tur KTur { get; set; }

    }
}
