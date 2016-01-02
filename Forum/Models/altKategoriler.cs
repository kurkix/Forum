using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class altKategoriler
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int altKategorilerID { get; set; }
        public string altKategorilerAd { get; set; }
        public string altKategorilerAciklama { get; set; }
        public virtual Kategoriler Kategoriler { get; set; }
        public ICollection<Konular> Konular { get; set; }


    }
}
