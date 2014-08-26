using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace ITCH2_1.Controllers
{
    public class ContenidoController : Controller
    {
        Models.Entities db = new Models.Entities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Publicacion(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = db.Pages.FirstOrDefault(page => page.page_id == id); 
            return View(model);
        }

        public ActionResult Busqueda(string id)
        {
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

        public ActionResult Categoria(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var category = db.Categories.FirstOrDefault(item => item.category_id == id);

            ViewBag.CategoryName = category.category_name;

            var paginas = db
               .Categories.FirstOrDefault(categoria => categoria.category_id == id)
               .Pages.Where(pagina => pagina.page_visible == true)
               .OrderByDescending(pagina => pagina.page_date);

            return View(paginas);
        }

    }
}
