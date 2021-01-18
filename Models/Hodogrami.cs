using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZiblinWebb.Models
{
    public partial class Hodogrami
    {
        [Key]
        public int Id { get; set; }
        public int Korisnik { get; set; }
        public int Klijent { get; set; }
        public string OstaliBrendovi { get; set; }
        public bool KratkaPrezentacija { get; set; }
        public string OpisPrezentacije { get; set; }
        public string ZainteresiraniZaProizvode { get; set; }
        public bool OstavljeneBrosure { get; set; }
        public string BrosureNijanseri { get; set; }
        public string Napomene { get; set; }
        public string Zakljucak { get; set; }
        public DateTime Datum { get; set; }
        public string UserId { get; set; }
        public int? KlijentId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
