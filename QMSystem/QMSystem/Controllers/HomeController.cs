using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QMSystem.Models;
using System;

namespace QMSystem.Controllers
{
    public class HomeController : Controller
    {
        private DocumentContext _context;

        public HomeController(DocumentContext context)
        {
            _context = context;
        }

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
        public ActionResult Create(string ChangeTitle, string Beschreibung, string myFile)
        {
            //_context.Documents.Add(document);
            //_context.SaveChanges();

            Documents document = new Documents();
            document.DocumentName = myFile;
            document.DocumentPath = "C:/TestPath";
            document.UserName = Environment.UserName;
            document.RequestDate = DateTime.Now;

            _context.Documents.Add(document);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}