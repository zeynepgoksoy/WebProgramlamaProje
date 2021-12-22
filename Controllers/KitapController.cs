using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitapKatalog.Models;

namespace KitapKatalog.Controllers
{
    public class KitapController : Controller
    {
        KitapKatalogContext c = new KitapKatalogContext();
        public IActionResult Index()
        {
            var kitaplar = c.Kitaps.ToList();
            return View(kitaplar);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Kitap k)
        {
            c.Kitaps.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
