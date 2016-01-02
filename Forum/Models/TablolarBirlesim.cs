using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class TablolarBirlesim
    {
        public IEnumerable<Kullanicilar> Kullanicilar { get; set; }
        public IEnumerable<Kategoriler> Kategoriler { get; set; }
        public IEnumerable<altKategoriler> altKategoriler { get; set; }
        public IEnumerable<Konular> Konular { get; set; }
    }
}
