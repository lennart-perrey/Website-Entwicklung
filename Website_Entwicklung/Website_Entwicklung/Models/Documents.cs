using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Website_Entwicklung.Models
{

    public class DocumentContext : DbContext
    {
        public DocumentContext() : base()
        {
        }

        public DocumentContext(DbContextOptions<DocumentContext> options)
            : base(options)
        { }

        public DbSet<Documents> Customers { get; set; }
    }
    public class Documents
    {
        public int DocumentId { get; set; }

        public string DocumentName { get; set; }

        public bool DocumentPath { get; set; }
    }
}