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

            var model = db.Pages.FirstOrDefault(page => page.page_id == id && page.page_visible == true); //ELIMINAR

            if (model == null) return HttpNotFound();

            return View(model);
        }

        public ActionResult AjaxPublicacion(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = db.Pages.FirstOrDefault(page => page.page_id == id);
            return PartialView("_PartialPublicacion", model);
        }

        public ActionResult AjaxCategorias()
        {
            return PartialView("_PartialCategorias");
        }

        public ActionResult AjaxUltimasPublicaciones()
        {
            return PartialView("_PartialUltimasPublicaciones");
        }

        public ActionResult AjaxNavigationButtons(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            List<Models.Pages> paginas = db.Pages
                .Where(item => item.page_visible == true)
                .OrderBy(item => item.page_date).ToList();

            if (!paginas.Exists(item => item.page_id == id)) return HttpNotFound();

            var model = paginas.First(item => item.page_id == id);
            
            List<Models.Pages> navigationPages = new List<Models.Pages>();
            
            navigationPages.Add(Previous(model, paginas));
            navigationPages.Add(Next(model, paginas));
            ViewBag.CurrentPageId = id;
            return PartialView("_PartialNavigationButtons", navigationPages);
        }


        #region NavigationHelperMethods
        public Models.Pages Next(Models.Pages current, List<Models.Pages> cityList)
        {
            int index = cityList.IndexOf(current);

            if (index < cityList.Count - 1)
                return cityList.ElementAt(index + 1);
            return current;
        }

        public Models.Pages Previous(Models.Pages current, List<Models.Pages> cityList)
        {
            int index = cityList.IndexOf(current);

            if (index >= 1)
                return cityList.ElementAt(index - 1);
            return current;
        } 
        #endregion


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
            if (category == null) return HttpNotFound();

            ViewBag.CategoryName = category.category_name;

            var paginas = db
               .Categories.FirstOrDefault(categoria => categoria.category_id == id)
               .Pages.Where(pagina => pagina.page_visible == true)
               .OrderByDescending(pagina => pagina.page_date);

            return View(paginas);
        }

    }
}
