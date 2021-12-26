using KitapKatalog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.ViewComponents
{
    public class KitapGetList : ViewComponent
    {
        private readonly KitapKatalogContext _context;
        
        public KitapGetList(KitapKatalogContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var kitaplar = _context.Kitaps.ToList();
            return View(kitaplar);
        }
    }
}
