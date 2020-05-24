using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UcenikController : Controller
    {
        public ActionResult Details(int id)
        {
            BibliotekaDB bdb = new BibliotekaDB();
            var Ucenik = bdb.Ucenik.FirstOrDefault(a => a.UcenikID == id);

            return View(Ucenik);
        }

        public ActionResult Edit(int id)
        {
            BibliotekaDB bdb = new BibliotekaDB();
            var Ucenik = bdb.Ucenik.FirstOrDefault(a => a.UcenikID == id);

            return View(Ucenik);
        }
        // GET: Ucenik
        public ActionResult Index()
        {
            BibliotekaDB bdb = new BibliotekaDB();
            var ucenici = bdb.Ucenik.ToList();

            return View(ucenici);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UcenikModel um)
        {

            BibliotekaDB bdb = new BibliotekaDB();
            var Ucenik = new UcenikModel();

            Ucenik.Ime = um.Ime;
            Ucenik.Prezime = um.Prezime;
            Ucenik.Razred = um.Razred;
            Ucenik.Odeljenje = um.Odeljenje;
            Ucenik.Telefon = um.Telefon;
            Ucenik.BrojUDnevniku = um.BrojUDnevniku;
            Ucenik.GodinaRodjenja = um.GodinaRodjenja;
            Ucenik.Email = um.Email;
            Ucenik.Adresa = um.Adresa;

            bdb.Ucenik.Add(um);
            bdb.SaveChanges();

            return RedirectToAction("Index");
        }


        // GET: Knjiga
        [HttpPost]
        public ActionResult Edit(UcenikModel um)
        {
      
            BibliotekaDB bdb = new BibliotekaDB();
            var Ucenik = bdb.Ucenik.FirstOrDefault(a => a.UcenikID == um.UcenikID);

            Ucenik.Ime = um.Ime;
            Ucenik.Prezime = um.Prezime;
            Ucenik.Razred = um.Razred;
            Ucenik.Odeljenje = um.Odeljenje;
            Ucenik.Telefon = um.Telefon;
            Ucenik.BrojUDnevniku = um.BrojUDnevniku;
            Ucenik.GodinaRodjenja = um.GodinaRodjenja;
            Ucenik.Email = um.Email;
            Ucenik.Adresa = um.Adresa;

            bdb.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }

            BibliotekaDB bdb = new BibliotekaDB();
            UcenikModel ucenik = bdb.Ucenik.Find(id);
            if (ucenik == null)
            {
                return HttpNotFound();
            }
            return View(ucenik);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                BibliotekaDB bdb = new BibliotekaDB();
                UcenikModel ucenik = bdb.Ucenik.Find(id);
                bdb.Ucenik.Remove(ucenik);
                bdb.SaveChanges();
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }
    }
}