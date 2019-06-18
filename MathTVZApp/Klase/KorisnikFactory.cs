using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MathTVZApp.Klase;

namespace MathTVZApp.Klase
{
    public class KorisnikFactory
    {
        public static UlogiraniKorisnik SpremiKorisnikaSesija(string korisnickoIme, string lozinka)
        {
            var korisnik = new UlogiraniKorisnik(korisnickoIme, lozinka);
            System.Web.HttpContext.Current.Session["UlogiraniKorisnik"] = korisnik; //spremanje objekta korisnika u sesiju
            return korisnik;
        }
    }
}