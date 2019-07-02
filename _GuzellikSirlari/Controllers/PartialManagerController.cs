using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _GuzellikSirlari.Concrete;
using _GuzellikSirlari.Models;

namespace _GuzellikSirlari.Controllers
{
    public class PartialManagerController:Controller
    {
        CiltBakimiConcrete cc = new CiltBakimiConcrete();
        CiltSagligiConcrete sc = new CiltSagligiConcrete();
        CiltSorunlariConcrete gc = new CiltSorunlariConcrete(); 
        DogalMaskelerConcrete dc = new DogalMaskelerConcrete();
        IletisimConcrete ic = new IletisimConcrete();

        [ChildActionOnly]
        public ActionResult Menu1() 
        {
            return PartialView(cc.ListData());
        }
        [ChildActionOnly]
        public ActionResult Menu2()
        {
            return PartialView(sc.ListData());
        }
        [ChildActionOnly]
        public ActionResult Menu3()
        {
            return PartialView(gc.ListData());
        }
        [ChildActionOnly]
        public ActionResult Menu4()  
        {
            return PartialView(dc.ListData());
        }
        [ChildActionOnly]
        public ActionResult Menu5()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Menu5(Iletisim model) 
        {
            try
            {
                ic.InsertData(model);           
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Oluştu: " + ex.Message);
            }
            return View(model);
        }
        public ActionResult DetaySayfasiMenu1(int CiltBakimiId)  
        {
            CiltBakimi p = cc.Sec(CiltBakimiId);

            return View(p);
        }
        public ActionResult DetaySayfasiMenu2(int CiltSagligiId)
        {
            CiltSagligi p = sc.Sec(CiltSagligiId); 

            return View(p);
        }
        public ActionResult DetaySayfasiMenu3(int CiltSorunlariId)
        { 
            CiltSorunlari p = gc.Sec(CiltSorunlariId); 

            return View(p);
        } 
        public ActionResult DetaySayfasiMenu4(int DogalMaskelerId)
        {
            DogalMaskeler p = dc.Sec(DogalMaskelerId); 

            return View(p);
        }

    }
}