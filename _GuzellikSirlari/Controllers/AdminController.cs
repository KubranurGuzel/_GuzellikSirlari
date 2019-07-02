using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _GuzellikSirlari.Models;
using System.IO;
using _GuzellikSirlari.Concrete;

namespace _GuzellikSirlari.Controllers
{
    public class AdminController :Controller
    {
        private GuzellikSirlariEntities1 db = new GuzellikSirlariEntities1();
        CiltBakimiConcrete cc = new CiltBakimiConcrete();
        CiltSagligiConcrete sc = new CiltSagligiConcrete();
        CiltSorunlariConcrete gc = new CiltSorunlariConcrete();
        DogalMaskelerConcrete dc = new DogalMaskelerConcrete();
        IletisimConcrete ic = new IletisimConcrete();

        public ActionResult Index()
        {
            Session["KullaniciId"] = null;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Kullanici model)
        {
            var kullanici = db.Kullanici.FirstOrDefault(x => x.KullaniciId == model.KullaniciId && x.KullaniciSifre == model.KullaniciSifre);
            if (kullanici != null)
            {
                Session["KullaniciId"] = kullanici;
                return RedirectToAction("Login", "Admin");
            }

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CiltBakimi() 
        {
            return View(cc.ListData());
        }
        public ActionResult CiltBakimiDetaylar(int CiltBakimiId) 
        {
            CiltBakimi p = cc.Sec(CiltBakimiId);
            return View(p);
        }
        public ActionResult CiltBakimiSil(int CiltBakimiId)
        {
            CiltBakimi p = cc.Sec(CiltBakimiId);
            return View(p);
        }
        [HttpPost]
        public ActionResult CiltBakimiSil(CiltBakimi model)
        {
            try
            {
                cc.DeleteData(model);
                return RedirectToAction("CiltBakimi");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }


        public ActionResult CiltBakimiEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CiltBakimiEkle(CiltBakimi model)
        {
            try
            {
                cc.InsertData(model);
                return RedirectToAction("CiltBakimi");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }

        public ActionResult CiltSagligi() 
        {
            return View(sc.ListData());
        }
        public ActionResult CiltSagligiDetaylar(int CiltSagligiId)
        {
            CiltSagligi p = sc.Sec(CiltSagligiId);
            return View(p);
        }
        public ActionResult CiltSagligiSil(int CiltSagligiId)
        {
            CiltSagligi p = sc.Sec(CiltSagligiId);
            return View(p);
        }
        [HttpPost]
        public ActionResult CiltSagligiSil(CiltSagligi model)
        {
            try
            {
                sc.DeleteData(model);
                return RedirectToAction("CiltSagligi");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }


        public ActionResult CiltSagligiEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CiltSagligiEkle(CiltSagligi model)
        {
            try
            {
                sc.InsertData(model);
                return RedirectToAction("CiltSagligi");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }

        public ActionResult CiltSorunlari()
        {
            return View(gc.ListData());
        }
        public ActionResult CiltSorunlariDetaylar(int CiltSorunlariId)
        {
            CiltSorunlari p = gc.Sec(CiltSorunlariId);
            return View(p);
        }
        public ActionResult CiltSorunlariSil(int CiltSorunlariId)
        {
            CiltSorunlari p = gc.Sec(CiltSorunlariId);
            return View(p);
        }
        [HttpPost]
        public ActionResult CiltSorunlariSil(CiltSorunlari model)
        {
            try
            {
                gc.DeleteData(model);
                return RedirectToAction("CiltSorunlari");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }


        public ActionResult CiltSorunlariEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CiltSorunlariEkle(CiltSorunlari model)
        {
            try
            {
                gc.InsertData(model);
                return RedirectToAction("CiltSorunlari");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }

        public ActionResult DogalMaskeler()
        {
            return View(dc.ListData());
        }
        public ActionResult DogalMaskelerDetaylar(int DogalMaskelerId)
        {
            DogalMaskeler p = dc.Sec(DogalMaskelerId);
            return View(p);
        }
        public ActionResult DogalMaskelerSil(int DogalMaskelerId)
        {
            DogalMaskeler p = dc.Sec(DogalMaskelerId);
            return View(p);
        }
        [HttpPost]
        public ActionResult DogalMaskelerSil(DogalMaskeler model)
        {
            try
            {
                dc.DeleteData(model);
                return RedirectToAction("DogalMaskeler");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }


        public ActionResult DogalMaskelerEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DogalMaskelerEkle(DogalMaskeler model)
        {
            try
            {
                dc.InsertData(model);
                return RedirectToAction("DogalMaskeler");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }



        public ActionResult Iletisim()
        {
            return View(ic.ListData());
        }
        public ActionResult IletisimDetaylar(int IletisimId)
        {
            Iletisim p = ic.Sec(IletisimId);
            return View(p);
        }
        public ActionResult IletisimSil(int IletisimId)
        {
            Iletisim p = ic.Sec(IletisimId);
            return View(p);
        }
        [HttpPost]
        public ActionResult IletisimSil(Iletisim model)
        {
            try
            {
                ic.DeleteData(model);
                return RedirectToAction("Iletisim");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }

    }
}