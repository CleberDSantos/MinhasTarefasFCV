using System.Web.Mvc;
using MinhasTarefas.UI.Models;

namespace MinhasTarefas.UI.Controllers
{
    public class CategoriaController : Controller
    {

        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria model)
        {

            using (var cont = new Contexto())
            {
                cont.Categorias.Add(model);
                cont.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}