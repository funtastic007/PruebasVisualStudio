using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebasVisualStudio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Comentario agregado desde dev_branch1
            return View();
        }

        public ActionResult About()
        {
            // Tercer comentario desde dev_branch1
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}