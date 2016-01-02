using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum.DAL;
using Forum.Models;

namespace Forum.Controllers
{
    public class ForumController : Controller
    {
        veritabaniContext db = new veritabaniContext(); //Veritabani nesnesi.
        TablolarBirlesim birlesim = new TablolarBirlesim(); //Tablolar tek bir modelde tablandı.
        // GET: Forum
        public ActionResult Index()
        {
            birlesim.altKategoriler = db.altKategoriTablosu.ToList();
            birlesim.Kategoriler = db.KategoriTablosu.ToList();
            birlesim.Konular = db.KonuTablosu.ToList();
            birlesim.Kullanicilar = db.KullaniciTablosu.ToList();
            return View(birlesim);
        }
    }
}