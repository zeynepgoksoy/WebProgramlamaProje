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
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir kullanıcı adı giriniz")]
        public string KullaniciAdi { get; set; }

        [StringLength(3)]
        [Required(ErrorMessage = "Şifre girilmelidir")]
        public string Sifre { get; set; }

        [StringLength(1)]
        public string Yetki { get; set; }


    }
}
