using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITCH2_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.ServidorImagenes = ITCH2_1.Properties.Settings.Default.ServidorImagenes;
            return View();
        }

    }
}
