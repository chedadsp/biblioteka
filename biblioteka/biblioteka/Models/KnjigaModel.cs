using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Knjiga")]
    public class KnjigaModel
    {
        [Key]
        public int KnjigaId { get; set; }

        public string InventarniBroj { get; set;  }

        public string Pisac { get; set; }

        public string Naslov { get; set; }

        public int GodinaIzdavanja { get; set; }

        public string MestoIzdavanja { get; set; }
    }
}