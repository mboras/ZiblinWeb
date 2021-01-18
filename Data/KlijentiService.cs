using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZiblinWebb.Models;
using ZiblinWebb.Data;


namespace ZiblinWebb.Data
{
    public class KlijentiService
    {
        private readonly ZiblinWebbContext db = new ZiblinWebbContext();
        private List<Klijenti> listaklijenata;


        public KlijentiService(ZiblinWebbContext db)
        {
            this.db = db;
        }

        public KlijentiService()
        {

        }


        public List<Klijenti> DohvatiSveKlijente()
        {
            listaklijenata = db.Klijenti.ToList();

            return listaklijenata;
        }

        public string KreirajKlijenta(Klijenti klijent)
        {
            db.Klijenti.Add(klijent);
            db.SaveChanges();

            return "Uspješno ste kreirali korisnika!";
        }

        public Klijenti DohvatiKlijentaPoId(int id)
        {
            Klijenti klijent = db.Klijenti.FirstOrDefault(s => s.Id == id);

            return klijent;
        }

        public string DohvatiNazivKlijentaPoId(int id)
        {
            Klijenti klijent = db.Klijenti.FirstOrDefault(s => s.Id == id);

            return klijent.NazivSalona;
        }


        public string UpdateKlijenta(Klijenti klijent)
        {
            db.Klijenti.Update(klijent);
            db.SaveChanges();

            return "Uspješno ste uredili podatke!";
        }

        public string DeleteKlijenta(Klijenti klijent)
        {
            db.Remove(klijent);
            db.SaveChanges();

            return "Uspješno ste izbrisali klijenta!";
        }








































    }
}
