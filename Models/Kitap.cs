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
        public int KitapID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public int KitapAdi { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string KitapGorsel { get; set; }
        public int KitapPuan { get; set; }
        public Yazar KYazar { get; set; }
    }
}
