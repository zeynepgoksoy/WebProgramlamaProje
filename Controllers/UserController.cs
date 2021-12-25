using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitapKatalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KitapKatalog.Controllers
{
    public class UserController : Controller
    {
        KitapKatalogContext c = new KitapKatalogContext();
        [AllowAnonymous]
        public IActionResult Index()
        {
            var users = c.Users.ToList();
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User u)
        {
            c.Users.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetUser(int id)
        {
            var user = c.Users.Find(id);
            return View("GetUser", user);

        }
        public IActionResult Update(User yeni)
        {
            var eski = c.Users.Find(yeni.UserId);
            eski.UserAd = yeni.UserAd;
            eski.UserSoyad = yeni.UserSoyad;
            eski.UserMail = yeni.UserMail;
            eski.Sifre = yeni.Sifre;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
