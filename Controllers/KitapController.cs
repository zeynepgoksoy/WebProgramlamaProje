using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitapKatalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KitapKatalog.Controllers
{
    public class KitapController : Controller
    {
        KitapKatalogContext c = new KitapKatalogContext();
        public IActionResult Index()
        {
            var kitaplar = c.Kitaps.Where(x=>x.Durum == true).Include(x => x.Yazar).Include(x=> x.Tur).ToList();
            return View(kitaplar);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> deger1 =(from x in c.Turs.ToList()
                                          select new SelectListItem
                                          {
                                                Text=x.TurAd,
                                                Value= x.TurId.ToString()
                                          }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Kitap k)
        {
            c.Kitaps.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var kitap = c.Kitaps.Find(id);
            kitap.Durum=false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetKitap(int id) 
        {
            List<SelectListItem> deger1 = (from x in c.Turs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.TurAd,
                                               Value = x.TurId.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            var kitap = c.Kitaps.Find(id);
            return View("GetKitap", kitap);

        }
        public IActionResult Update(Kitap yeni)
        {
            var eski = c.Kitaps.Find(yeni.KitapId);
            eski.KitapAdi = yeni.KitapAdi;
            eski.KitapId = yeni.KitapId;
            eski.KitapPuan = yeni.KitapPuan;
            eski.KitapSayfa = yeni.KitapSayfa;
            eski.KitapGorsel = yeni.KitapGorsel;
            eski.KitapTanıtım = yeni.KitapTanıtım;
            eski.TurId = yeni.TurId;
            eski.YazarId = yeni.YazarId;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
