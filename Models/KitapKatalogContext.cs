using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace KitapKatalog.Models
{
    public class KitapKatalogContext : DbContext
    {
        //Tablolarımızı oluşturuyoruz
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Tur> Turs { get; set; }
        public DbSet<KitapListe> KitapListes{ get; set; }

        public KitapKatalogContext(DbContextOptions<KitapKatalogContext> options ) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer(@"Server= (localdb)\mssqllocaldb; Database=KitapKatalog ; Trusted_Connection=True;"); 
        }

    }
}
