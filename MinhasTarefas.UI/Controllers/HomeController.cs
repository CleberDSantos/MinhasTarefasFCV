using System.Web.Mvc;

namespace MinhasTarefas.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Sobre()
        {

            return View();
        }
    }
}