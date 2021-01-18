using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZiblinWebb.Models;

namespace ZiblinWebb.Data
{
    public class PromoMaterijaliService
    {
        private readonly ZiblinWebbContext db = new ZiblinWebbContext();
        private List<PromoMaterijali> listaPromoMaterijala;

        public PromoMaterijaliService(ZiblinWebbContext db)
        {
            this.db = db;
        }

        public PromoMaterijaliService()
        {

        }

        public List<PromoMaterijali> DohvatiSvePromoMaterijale()
        {
            listaPromoMaterijala = db.PromoMaterijali.ToList();

            return listaPromoMaterijala;
        }

        public string DodajPromoMaterijal(PromoMaterijali promoMaterijal)
        {
            db.PromoMaterijali.Add(promoMaterijal);
            db.SaveChanges();

            return "Uspješno dodan promo materijal!";
        }

        public PromoMaterijali DohvatiPromoMaterijalPoId(int id)
        {
            PromoMaterijali promoMaterijal = db.PromoMaterijali.FirstOrDefault(s => s.Id == id);

            return promoMaterijal;
        }

        public string UpdatePromoMaterijal(PromoMaterijali promoMaterijal)
        {
            db.PromoMaterijali.Update(promoMaterijal);
            db.SaveChanges();

            return "Uspješno ste uredili podatke!";
        }

        public string DeletePromoMaterijal(PromoMaterijali promoMaterijal)
        {
            db.Remove(promoMaterijal);
            db.SaveChanges();

            return "Uspješno ste izbrisali korisnika!";
        }















    }
}
