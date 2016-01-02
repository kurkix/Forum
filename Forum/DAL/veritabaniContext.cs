using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Forum.DAL
{
    public class veritabaniContext:DbContext
    {
        public veritabaniContext():base ("veritabaniContext")
        {

        }
        public DbSet<Kategoriler> KategoriTablosu { get; set; }
        public DbSet<Konular> KonuTablosu { get; set; }
        public DbSet<Kullanicilar> KullaniciTablosu { get; set; }
        public DbSet<altKategoriler> altKategoriTablosu { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    
}
