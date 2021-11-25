using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutuphane_sistemi.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Kitap_adi { get; set; }
        public string Kitap_tur { get; set; }
        public string Kitap_yazar { get; set; }

        public string Uye_adi { get; set; }
        public string Uye_soyad { get; set; }

    }
}
