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
    }
}
