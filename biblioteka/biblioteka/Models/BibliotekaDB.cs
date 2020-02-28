using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BibliotekaDB : DbContext
    {
        public BibliotekaDB() : base("BibliotekaContext")
        { }

        public DbSet<KnjigaModel> Knjiga { get; set; }

    }
}