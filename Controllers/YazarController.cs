using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitapKatalog.Models;

namespace KitapKatalog.Controllers
{
    public class YazarController : Controller
    {
        KitapKatalogContext c = new KitapKatalogContext();
        public IActionResult Index()
        {
            var yazarlar = c.Yazars.ToList();
            return View(yazarlar);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Yazar y)
        {
            c.Yazars.Add(y);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var yazar = c.Yazars.Find(id);
            c.Yazars.Remove(yazar);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult GetYazar(int id)
        {
            var yazar = c.Yazars.Find(id);
            return View("GetYazar",yazar);
        }
        public IActionResult Update(Yazar y)
        {
            var yazar = c.Yazars.Find(y.YazarId);
            yazar.YazarAd = y.YazarAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult YazarDetay(int id)
        {
            var kitaplar = c.Kitaps.Where(x => x.YazarId == id).ToList();
            var yzrAd  = c.Yazars.Where(x => x.YazarId == id).Select(y=> y.YazarAd).FirstOrDefault();
            var yzrSoyad = c.Yazars.Where(x=>x.YazarId ==id).Select(y=>y.YazarSoyad).FirstOrDefault();
            ViewBag.Ad = yzrAd;
            ViewBag.Soyad = yzrSoyad;
            return View(kitaplar);
        }
    }
}
