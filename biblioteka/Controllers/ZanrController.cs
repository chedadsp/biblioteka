using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ZanrController : Controller
    {
        // GET: Zanr
        public ActionResult Index()
        {
            BibliotekaDB bdb = new BibliotekaDB();
            List<ZanrModel> Zanr = bdb.Zanr.ToList();

            return View(Zanr);
            
        }
    }
}