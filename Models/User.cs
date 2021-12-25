using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Models
{
    public class User
    {
     
            [Key]
            public int UserId { get; set; }

            [StringLength(30)]
            [Required(ErrorMessage = "Kullanıcı adı girilmelidir")]
            public string UserAd { get; set; }

            [StringLength(30)]
            [Required(ErrorMessage = "Kullanıcı soyadı girilmelidir")]
            public string UserSoyad { get; set; }

            [StringLength(50)]
            [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail adresi giriniz")]
            public string UserMail { get; set; }
            [StringLength(30)]
            [Required(ErrorMessage = "Şifre girilmelidir")]
            public string Sifre { get; set; }
        
    }
}
