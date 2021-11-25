using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutuphane_sistemi.Models
{
    public class Kitap_veri
    {
        public static List<Kitap> Kitaplar = new List<Kitap>(){
            new Kitap()
            {
                Id = 1,
                Kitap_adi = "Otomatik Portakal",
                Kitap_tur = "Roman",
                Kitap_yazar = "Anthony Burgess",
                Uye_adi = "Samet",
                Uye_soyad = "Yılmaz",

            },

            new Kitap()
            {
                Id = 2,
                Kitap_adi = "Bilinmeyen Bir Kadının Mektubu",
                Kitap_tur = "Kurgu",
                Kitap_yazar = "Stefan Zweig",
                Uye_adi = "Mehmet",
                Uye_soyad = "Karpuz",
            },

            new Kitap()
            {
                Id = 3,
                Kitap_adi = "Üç Yıl",
                Kitap_tur = "Kurgu",
                Kitap_yazar = "Anton Çehov",
                Uye_adi = "Fatih",
                Uye_soyad = "Farklıyüz",
            }

        };
    }
}
