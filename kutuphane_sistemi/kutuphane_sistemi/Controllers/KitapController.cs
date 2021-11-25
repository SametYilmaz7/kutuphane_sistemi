using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kutuphane_sistemi.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult kitaplistele()
        {
            return View(Models.Kitap_veri.Kitaplar);
        }

        public IActionResult kitapolustur()
        {
            return View();
        }

        [HttpPost]
        public IActionResult kitapolustur(Models.Kitap kitapOlustur)
        {
            Models.Kitap_veri.Kitaplar.Add(kitapOlustur);
            return RedirectToAction("KitapListele");
        }

        public IActionResult kitapguncelle(int id)
        {
            var a = Models.Kitap_veri.Kitaplar.FirstOrDefault(x => x.Id == id);
            return View(a);
        }

        [HttpPost]
        public IActionResult kitapguncelle(Models.Kitap kitap)
        {
            var a = Models.Kitap_veri.Kitaplar.FirstOrDefault(x => x.Id == kitap.Id);
            var b = Models.Kitap_veri.Kitaplar.FirstOrDefault(x => x.Id == kitap.Id);
            b.Kitap_adi = kitap.Kitap_adi;
            b.Kitap_tur = kitap.Kitap_tur;
            b.Kitap_yazar = kitap.Kitap_yazar;
            b.Uye_adi = kitap.Uye_adi;
            b.Uye_soyad = kitap.Uye_soyad;

            Models.Kitap_veri.Kitaplar.Remove(a);
            Models.Kitap_veri.Kitaplar.Add(b);

            return RedirectToAction("KitapListele");

        }

        public IActionResult kitapdetay(int id)
        {
            var a = Models.Kitap_veri.Kitaplar.FirstOrDefault(x => x.Id == id);
            return View(a);
        }

        public IActionResult kitapsil(int id)
        {
            var a = Models.Kitap_veri.Kitaplar.FirstOrDefault(x => x.Id == id);
            return View(a);
        }

        [HttpPost]
        public IActionResult kitapsil(Models.Kitap kitap)
        {
            var r = Models.Kitap_veri.Kitaplar.FirstOrDefault(x => x.Id == kitap.Id);
            Models.Kitap_veri.Kitaplar.Remove(r);
            return RedirectToAction("KitapListele");
        }


    }

}
