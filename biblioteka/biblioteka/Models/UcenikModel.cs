using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UcenikModel
    {
        public int UcenikID { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public int GodinaRodjenja { get; set; }

        public int BrojUDnevniku { get; set; }

        public string Razred { get; set; }

        public string Odeljenje { get; set; }
    }
}