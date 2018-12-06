using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QMSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QMSystem.Controllers
{
    public class HomeController : Controller
    {

        string savePath = @"C:/Temp/uploads/";

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
        public async Task<IActionResult> Create(string ChangeTitle, string Beschreibung, IFormFile myFile)
        {
            Documents document = new Documents();
            document.DocumentName = myFile.FileName;
            //document.DocumentPath = "C:/TestPath";
            document.UserName = Environment.UserName;
            document.RequestDate = DateTime.Now;

            _context.Documents.Add(document);
            _context.SaveChanges();
            savePath += myFile.FileName;

            using (var stream = new FileStream(savePath, FileMode.Create))
            {
                await myFile.CopyToAsync(stream);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}