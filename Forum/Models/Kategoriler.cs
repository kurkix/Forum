using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Kategoriler
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KategorilerID { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklama { get; set; }
        public ICollection<Konular> Konu { get; set; }
    }
}
