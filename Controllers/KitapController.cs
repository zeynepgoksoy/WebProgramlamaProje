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
    }
}
