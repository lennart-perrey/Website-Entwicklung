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

        string savePath = @"C:\Temp\uploads\";

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

        public ActionResult AdminTool()
        {
            List<Documents> documents = _context.Documents.ToList();
            return View(documents);

        }
        public void ChangeStatus(int DocumentId, int Freigabe)
        {
            string Query="UPDATE Documents SET Freigabe=Freigabe where DocumentId==DocumentId";
           
            Documents document = new Documents();
            if (document.DocumentId == DocumentId)
;            {
                document.Freigabe = Freigabe;
            }

            _context.SaveChanges();
        }
        //Add Document to DB
        [HttpPost]
        public async Task<IActionResult> Create(string ChangeTitle, string Beschreibung, IFormFile myFile)
        {
            savePath += myFile.FileName;

            Documents document = new Documents();
            document.DocumentName = myFile.FileName;
            document.DocumentPath = savePath;
            document.UserName = Environment.UserName;
            document.RequestDate = DateTime.Now;
            document.Betreff = ChangeTitle;
            document.Anmerkungen = Beschreibung;
            document.Freigabe = 0;

            _context.Documents.Add(document);
            _context.SaveChanges();
            

            using (var stream = new FileStream(savePath, FileMode.Create))
            {
                await myFile.CopyToAsync(stream);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}