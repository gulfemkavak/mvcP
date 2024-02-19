using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mvcP.Models
{
    public class personel
    {

        [Key]
        public int perID { get; set; }

        public string ad { get; set; }
        public string soyad { get; set; }
        public String sehir { get; set; }

        public int BirimID { get; set; }
        public Birim Birim { get; set; }
    }
}
