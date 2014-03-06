using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITCH2_1.Controllers
{
    public class ContenidoController : Controller
    {
        //
        // GET: /Contenido/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Publicacion(int id)
        {
            Models.Entities db = new Models.Entities();
            var model = db.Pages.FirstOrDefault(page => page.page_id == id); 
            return View(model);
        }

        public ActionResult Busqueda(string id)
        {
            Models.Entities db = new Models.Entities();
            var paginas = db.Pages
                .Where(pagina =>
                    pagina.page_visible == true)
                .Where(pagina =>
                    pagina.page_content.Contains(id)
                    ||
                    pagina.page_title.Contains(id)
                );


            return View(paginas);
        }

        
        [HttpPost]
        public ActionResult Busqueda(FormCollection formcollection)
        {
            return RedirectToAction("Busqueda", "Contenido", new { id = formcollection[0] });
        }

        public ActionResult Categoria(string id)
        {
            return View();
        }

    }
}
