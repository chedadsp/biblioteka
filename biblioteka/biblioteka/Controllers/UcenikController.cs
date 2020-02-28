using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UcenikController : Controller
    {
        // GET: Ucenik
        public ActionResult NoviUcenik()
        {
            return View();
        }

        // GET: Knjiga
        [HttpPost]
        public ActionResult NoviUcenik(UcenikModel um)
        {
            return View();
        }
    }
}