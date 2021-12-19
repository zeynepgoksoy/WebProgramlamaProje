using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitapKatalog.Models;

namespace KitapKatalog.Controllers
{
    public class TurController : Controller
    {
        //GET: Kategori
        KitapKatalogContext c = new KitapKatalogContext();
        public IActionResult Index()
        {
            var degerler= c.Turs.ToList();

            return View(degerler);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tur t)
        {
            c.Turs.Add(t);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var tur_vrb = c.Turs.Find(id);
            c.Turs.Remove(tur_vrb);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetTur(int id)
        {
            var tur_vrb = c.Turs.Find(id);
            return View("GetTur",tur_vrb);
        }
        public IActionResult Update(Tur t)
        {
            var tur_vrb= c.Turs.Find(t.TurId);
            tur_vrb.TurAd = t.TurAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
