using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPage.Controllers
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

        public ActionResult SobreGrupo()
        {
            ViewBag.Message = "Página com informações sobre os membros do grupo.";

            return View();
        }

        public ActionResult Documentacao()
        {
            ViewBag.Message = "Página com os documentos do projeto.";

            return View();
        }
    }
}