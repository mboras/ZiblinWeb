using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZiblinWebb.Models
{
    public partial class Klijenti
    {
        [Key]
        public int Id { get; set; }
        public string SifraSalona { get; set; }
        public string NazivSalona { get; set; }
        public string Adresa { get; set; }
        public string Mjesto { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mobitel { get; set; }
        public bool Facebook { get; set; }
        public bool Instagram { get; set; }
        public string Vlasnik { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        //public int KlijentaDodao { get; set; }
        public DateTime DatumDodavanja { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }

























    }
}
