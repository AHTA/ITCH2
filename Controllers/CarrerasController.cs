using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITCH2_1.Controllers
{
    public class CarrerasController : Controller
    {
        //
        // GET: /Carreras/

        public ActionResult Index()
        {
            return RedirectToAction("ISC");
        }

        public ActionResult ISC()
        {
            return View();
        }

        public ActionResult ARQ()
        {
            return View();
        }

        public ActionResult LI()
        {
            return View();
        }

        public ActionResult LA()
        {
            return View();
        }

        public ActionResult IGE()
        {
            return View();
        }

        public ActionResult IINF()
        {
            return View();
        }

        public ActionResult II()
        {
            return View();
        }

    }
}
