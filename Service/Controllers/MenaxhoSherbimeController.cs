using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using servisi.Models;


namespace servisi.Controllers
{
    public class MenaxhoSherbimeController : Controller
    {
        // GET: MenaxhoSherbime
        public ActionResult Sherbimi()
        {
            Mekaniku mek = new Mekaniku();
            List<Mekaniku> ls = mek.ListeMekanikesh();
            ViewBag.Liste = new SelectList(ls, "isdn", "emri");
            return View();
        }

        public ActionResult SherbimPost()
        {

            Mekaniku mek = new Mekaniku();
            List<Mekaniku> ls = mek.ListeMekanikesh();
            ViewBag.Liste = new SelectList(ls, "isdn", "emri");
            string message = string.Empty;
            int idSherbimi = 0;
            string emer = Request.Form["txtEmri"];
            int idMek = Convert.ToInt32(Request.Form["Liste"]);
            string tipi = Request.Form["txtTipi"];
            string pershkrim = Request.Form["txtPershkrim"];
            Sherbim newSherbim = new Sherbim(emer, idMek, tipi, pershkrim);
            newSherbim.ShtoSherbimNeDatabaze(out message, out idSherbimi);
            TempData["idSherbimi"] = idSherbimi;
            TempData["message1"] = message + " " + idSherbimi;

            return RedirectToAction("DetajeSherbim", "MenaxhoSherbime", new { @id = idSherbimi });

        }


        public ActionResult DetajeSherbim(int id)
        {
            Pjese pj = new Pjese();
            List<Pjese> ls = pj.ListePjesesh();
            ViewBag.Liste = new SelectList(ls, "idPjese", "emri");
            
            ViewBag.Message1 = TempData["message1"];
            ViewBag.Message2 = TempData["message"];
            
            return View();
        }

        public ActionResult DetajeSherbimiPost()
        {
            string message = string.Empty;
            
            Pjese pj = new Pjese();
            List<Pjese> ls = pj.ListePjesesh();
            ViewBag.ListPjese = new SelectList(ls, "idPjese", "emri");
            int idSherbimi = Convert.ToInt32(TempData["idSherbimi"]);
            int idPjese = Convert.ToInt32(Request.Form["Liste"]);
            int sasi = Convert.ToInt32(Request.Form["txtSasia"]);
            int cmimi = Convert.ToInt32(Request.Form["txtCmimi"]);
            DetajeSherbimi dSh = new DetajeSherbimi(idSherbimi, idPjese, sasi,cmimi);
            dSh.ShtoDetajeNeDataBaze(out message);
            TempData["message"] = message;
            return RedirectToAction("DetajeSherbim", "MenaxhoSherbime", new { @id = idSherbimi });
        }

        

        public ActionResult SherbimiDone()
        {
            string message = string.Empty;
            DetajeSherbimi dSh = new DetajeSherbimi(Convert.ToInt32(TempData["idSherbimi"]));
            dSh.LlogaritCmim(out message);
            ViewBag.Message = message;
            return View();
        }


        public ActionResult HapSherbimMakine()
        {
            Sherbim sherb = new Sherbim();
            List<Sherbim> ls = sherb.ListeSherbimi();
            ViewBag.Liste = new SelectList(ls, "idSherbimi", "emer");
            
            return View();
        }

        public ActionResult HapSherbimMakinePost()
        {
            Sherbim sherb = new Sherbim();
            List<Sherbim> ls = sherb.ListeSherbimi();
            ViewBag.Liste = new SelectList(ls, "idSherbimi", "emer");
            string message = string.Empty;
            string targe = Request.Form["txtTarge"];
            int idSherbimi = Convert.ToInt32(Request.Form["Liste"]);
            DateTime date = Convert.ToDateTime(Request.Form["txtDate"]);
            int status = 0;
            Makine mak = new Makine(targe);
            bool flag = mak.checkMakine(out message);
            if (flag == true)
            {
                SherbimMakine sherbim = new SherbimMakine(idSherbimi, targe, date, status);
                sherbim.ShtoNeDataBaze(out message);
                ViewBag.Message = message;
            }
            else
            {
                ViewBag.Message = "Nuk ka makine me kete targe ne databaze";
            }
            
            return View("HapSherbimMakine");
        }


        public ActionResult SelectTarge()
        {
            return View();
        }

        public ActionResult SelectTargePost()
        {
            string targe = Request.Form["txtTarge"];
            SherbimMakine sherbim = new SherbimMakine(targe);
            
            return RedirectToAction("UpdateStatus","MenaxhoSherbime",new {targa=targe});
        }

        public ActionResult UpdateStatus(string targa)
        {
            SherbimMakine sherb = new SherbimMakine(targa);
            ViewBag.Liste = sherb.ListeSherbimi();
            
            
            return View();
        }

        public ActionResult UpdateStatusRedirect()
        {

            return View();
        }

        public ActionResult UpdateStatusRedirected(int id)
        {
            Session["idSherbimi"] = id;

            return View();
        }

        public ActionResult UpdateStatusPost()
        {
            string message =  string.Empty;
            int id = Convert.ToInt32(Session["idSherbimi"]);
            int status = Convert.ToInt32(Request.Form["rs8"].ToString());

            SherbimMakine sherbim = new SherbimMakine(id,status);
            sherbim.UpdateStatus(out message);
            ViewBag.Message = message;
            return View();
        }
        public ActionResult UpdateMekanik()
        {
            return View();
        }
        public ActionResult UpdateMekanikPOST()
        { 
            string mess = string.Empty;
            int Id = Convert.ToInt32(Request.Form["rtxt13"]);
            string npu= Request.Form["rtxt14"];
            UpdateMekanik mmeku = new UpdateMekanik(Id, npu);
            mmeku.UpdateMekaniktodb(out mess);
            ViewBag.Message = mess;
            return View("UpdateMekanik");

        }

        public ActionResult MenaxhoSherbim()
        {
            return View();
        }
    }
}