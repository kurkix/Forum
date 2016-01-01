using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Konular
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KonularID { get; set; }
        public string Baslik { get; set; }
        public string İcerik { get; set; }
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
