using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_Entwicklung.Models;

namespace Website_Entwicklung.Controllers
{
    public class HomeController : Controller
    {
        private DocumentContext _context;

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

        public ActionResult Neuigkeiten()
        {
            return View();
        }

        public ActionResult Aufgaben()
        {
            return View();
        }

        public ActionResult ChangeRequests()
        {
            return View();
        }

        public ActionResult Veraenderungen()
        {
            return View();
        }

        public ActionResult RelevanteProzesse()
        {
            return View();
        }

        public ActionResult RelevanteDokumente()
        {
            return View();
        }

        //Add Document to DB

        [HttpPost]
        public ActionResult Create(Documents document)
        {
            _context.Customers.Add(document);
            _context.SaveChanges();

            return RedirectToAction("Index", "ChangeRequest");
        }
    }
}