using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Models
{
    public class KitapListe
    {
        [Key]
        public int ListeId { get; set; }
        public int KitapAdet { get; set; }

        public DateTime Tarih { get; set; }
        
        //public int User (Üye bilgisi)
        public ICollection<Kitap> Kitaps { get; set; }

    }
}
