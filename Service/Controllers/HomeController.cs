using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using servisi.Models;

namespace servisi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult shtopjese()
        {
            
           
            return View();
        }

        public ActionResult shtopjesPOST()
        {
            string message = string.Empty;
            string emer = Request.Form["rtxt1"];
            int sasi = Convert.ToInt32(Request.Form["rtxt3"]);
            int cmimi = Convert.ToInt32(Request.Form["rtxt4"]);
            string pershkrim = Request.Form["rtxt5"];
            Pjesa pjeseERe = new Pjesa(emer, sasi, pershkrim, cmimi);
            pjeseERe.ShtoNeDataBaze(out message);
            ViewBag.Message = message;
            return View("shtopjese");
            
        }
        public ActionResult sasipjesesh()
        {
            ViewBag.Message = " Sasia e re e pjeseve";
            return View();
        }

        public ActionResult updatePjese()
        {
            string message = string.Empty;

            string emer = Request.Form["rtxt1"];
            int sasia = Convert.ToInt32(Request.Form["rtxt2"]);
            Pjesa pjese_Sasi = new Pjesa(emer, sasia);

            pjese_Sasi.UpdatePjese(out message);

            ViewBag.Message = message;

            return View("sasipjesesh");
        }

        public ActionResult kerkopjese()
        {
            return View();
        }
        public ActionResult RegjistroMakine()
        {
            return View();
        }
        public ActionResult RegjistroMakinePOST()
        {
            string message = string.Empty;
            string Targa = Request.Form["rtxt5"];
            string marka = Request.Form["rs1"];
            string tipi = Request.Form["rs2"];
            string ngjyra = Request.Form["rtxt6"];
             Makina makin = new Makina(Targa, marka, tipi,  ngjyra);
            makin.InsertDb(out message);
            ViewBag.Message = message;
            return View("RegjistroMakine");
        }

        public ActionResult ReggistroMekanik()
        {
            return View();

        }
        public ActionResult RegjistroMekanikPOST()
        {
            string message = string.Empty;
            int NRid= Convert.ToInt32( Request.Form["rtxt6"]);
            string emri= Request.Form["rtxt7"];
            string mb = Request.Form["rtxt8"];
            int mosha=Convert.ToInt32( Request.Form["rtxt9"]);
            string sp = Request.Form["rtxt11"];
            string npu = Request.Form["rtxt10"];
            RMekanik mekanikuu = new RMekanik(NRid, emri, mb, mosha,sp,npu);
            mekanikuu.InserttoDb(out message);
            ViewBag.Message = message;
            return View("ReggistroMekanik");
        }
        public ActionResult ShfaqPjes()
        {
            Pjesa pjeset = new Pjesa();
            ViewBag.Liste = pjeset.ShfaqPjeset(); 
            return View();
        }

        public ActionResult ViewButona()
        {
            return View();
        }

        public ActionResult MenaxhoMekanike()
        {
            return View();
        }
        
    }
}