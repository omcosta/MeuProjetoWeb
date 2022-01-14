using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuPrimeiroProjetoWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de Descrição da Aplicação";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dados para Contato";

            return View();
        }
    }
}