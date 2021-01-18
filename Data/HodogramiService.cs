using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZiblinWebb.Models;


namespace ZiblinWebb.Data
{
    public class HodogramiService
    {
        private readonly ZiblinWebbContext db = new ZiblinWebbContext();
        private List<Hodogrami> listaHodograma;

        public HodogramiService(ZiblinWebbContext db)
        {
            this.db = db;
        }
        public HodogramiService()
        {

        }

        public List<Hodogrami> DohvatiSveHodograme()
        {
            listaHodograma = db.Hodogrami.ToList();

            return listaHodograma;
        }

        public List<Hodogrami> DohvatiHodogrameKorisnika(string id)
        {
            List<Hodogrami> results = db.Hodogrami.Where(x => x.UserId == id).ToList();
            return results;
        }

        public string KreirajHodogram(Hodogrami hodogram)
        {
            db.Hodogrami.Add(hodogram);
            db.SaveChanges();

            return "Uspješno dodano!";
        }

        public Hodogrami DohvatiHodogramPoId(int id)
        {
            Hodogrami hodogram = db.Hodogrami.FirstOrDefault(s => s.Id == id);
            return hodogram;
        }

        public string UpdateHodograma(Hodogrami hodogram)
        {
            db.Hodogrami.Update(hodogram);
            db.SaveChanges();

            return "Uspješno ste uredili podatke!";
        }

        public string DeleteHodogram(Hodogrami hodogram)
        {
            db.Remove(hodogram);
            db.SaveChanges();

            return "Uspješno izbrisano!";
        }










    }
}
