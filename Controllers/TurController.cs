using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Controllers
{
    public class TurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
