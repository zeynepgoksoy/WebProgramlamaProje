using KitapKatalog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapKatalog.Controllers
{
    public class AdminController : Controller
    {
        KitapKatalogContext c = new KitapKatalogContext();
        [AllowAnonymous]
        public IActionResult Index()
        {
            var admins = c.Admins.ToList();
            return View(admins);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Admin u)
        {
            c.Admins.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetAdmin(int id)
        {
            var admin = c.Admins.Find(id);
            return View("GetAdmin", admin);

        }
        public IActionResult Update(Admin yeni)
        {
            var eski = c.Admins.Find(yeni.AdminId);
            eski.KullaniciAdi = yeni.KullaniciAdi;
            eski.Yetki = yeni.Yetki;
            eski.Sifre = yeni.Sifre;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
