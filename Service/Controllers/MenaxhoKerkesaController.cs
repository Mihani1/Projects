using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using servisi.Models;
namespace servisi.Controllers
{
    public class MenaxhoKerkesaController : Controller
    {
        // GET: MenaxhoKerkesa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListoKerkesa()
        {
            KerkeseSherbimi kerk = new KerkeseSherbimi();
            List<KerkeseSherbimi> ls = kerk.ListoKerkesId();
            ViewBag.Liste = ls;
            return View();
        }

        public ActionResult KerkeseDetails(int id)
        {
            ViewBag.Id = id;
            KerkeseSherbimi kerk = new KerkeseSherbimi(id);
            List<KerkeseSherbimi> ls = kerk.ListoKerkese();
            ViewBag.List = ls;
            TempData["idKerkese"] = id;
            return View();
        }

        public ActionResult UpdateStatusKerkese()
        {

            KerkeseSherbimi kerkese = new KerkeseSherbimi(Convert.ToInt32(TempData["idKerkese"]));
            kerkese.UpdateStatusKerkese();
            return RedirectToAction("KerkeseDetails","MenaxhoKerkesa",new{id=kerkese.idKerkeseSherbimi});
        }


    }
}