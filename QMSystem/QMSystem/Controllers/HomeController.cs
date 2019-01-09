﻿using Microsoft.AspNetCore.Http;
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

        string savePath = @"C:\tmp\uploads\";
        string freigabePfad = @"C:\tmp\freigabe\";

        private DocumentContext _context;

        public HomeController(DocumentContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            User user = new User();
            user.UserName = Environment.UserName;
            return View(user);
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

        public ActionResult History()
        {
            List<Documents> documents = _context.Documents.ToList();
            return View(documents);
        }

        public ActionResult ChangeRequests()
        {
            return View();
        }
        
        public ActionResult AdminTool()
        {
            List<Documents> documents = _context.Documents.ToList();
            return View(documents);

        }
        public ActionResult UpdateState(string documentID, string status)
        {
            List<Documents> documents = _context.Documents.ToList();
            foreach (Documents document in documents)
            {

                if (document.DocumentId == Convert.ToInt32(documentID))

                {
                    int Freigabe = 0;

                    if (status == "Direkte Freigabe")
                    {
                        Freigabe = 1;
                        freigabePfad += document.DocumentName;
                        if (document.DocumentPath != freigabePfad)
                        {
                            System.IO.File.Copy(document.DocumentPath, freigabePfad, true);
                        }

                        document.DocumentPath = freigabePfad;
                    }
                    else if (status == "Weitergabe an GF")
                    {
                        Freigabe = 2;
                    }
                    else if (status == "Abgelehnt")
                    {
                        Freigabe = 3;
                    }

                    else if (status == "Veröffentlicht")
                    {
                        Freigabe = 4;
                        document.ReleaseDate = DateTime.Now;
                    }

                    document.Freigabe = Freigabe;

                    _context.Documents.Update(document);
                    _context.SaveChanges();

                    
                }
            }
            return RedirectToAction("AdminTool", "Home");
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