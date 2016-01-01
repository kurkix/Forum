using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Kullanicilar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KullanicilarID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }
        public ICollection<Konular> Konular { get; set; }
    }
}
