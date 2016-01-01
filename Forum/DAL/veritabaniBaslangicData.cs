using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Models;

namespace Forum.DAL
{
    public class veritabaniBaslangicData:System.Data.Entity.DropCreateDatabaseIfModelChanges<veritabaniContext>
    {
        protected override void Seed(veritabaniContext context)
        {
            var Kullanicilar = new List<Kullanicilar>
            {
                new Kullanicilar {KullanicilarID=1,Ad="Burak",Soyad="Demirci",Email="burakdemirci.34@gmail.com",KullaniciAdi="kurkix" }
            };

            Kullanicilar.ForEach(s => context.KullaniciTablosu.Add(s));
            context.SaveChanges();
            var Kategoriler = new List<Kategoriler>
            {
                new Kategoriler {KategorilerID=1,KategoriAdi="Deneme",KategoriAciklama="Bu kategori deneme amaçlı açılmıştır." }
            };
            Kategoriler.ForEach(s => context.KategoriTablosu.Add(s));
            context.SaveChanges();
            var Konular = new List<Konular>
            {
                new Konular {KonularID=1,Baslik="Hoşgeldiniz",Icerik="Forum sistemine hoşgeldiniz." }
            };
            Konular.ForEach(s => context.KonuTablosu.Add(s));
            context.SaveChanges();

        }
    }
}
