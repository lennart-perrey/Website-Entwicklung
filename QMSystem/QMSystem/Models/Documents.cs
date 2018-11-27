using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMSystem.Models
{

    public class DocumentContext : DbContext
    {
        public DocumentContext() : base()
        {
        }

        public DocumentContext(DbContextOptions<DocumentContext> options)
            : base(options)
        { }

        public DbSet<Documents> Documents { get; set; }
    }
    public class Documents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentId { get; set; }

        public string DocumentName { get; set; }

        public string DocumentPath { get; set; }
    }
}