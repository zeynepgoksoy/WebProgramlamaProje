using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Models
{
    public class KitapListe
    {
        public int ListeId { get; set; }
        public int KitapAdet { get; set; }

        public DateTime Tarih { get; set; }
        public ICollection<Kitap> Kitaps { get; set; }
        public ICollection<Yazar> Yazars { get; set; }


    }
}
