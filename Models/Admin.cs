using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [StringLength(30)]
        public string KullanıcıAdi { get; set; }

        [StringLength(30)]
        public string Sifre { get; set; }

        [StringLength(1)]
        public string Yetki { get; set; }


    }
}
