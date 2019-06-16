using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MathTVZApp.Klase;

namespace MathTVZApp.Klase
{
    public class KorisnikFactory
    {
        public static UlogiraniKorisnik StvoriKorisnika(string korisnickoIme, string lozinka)
        {
            var korisnik = new UlogiraniKorisnik(korisnickoIme, lozinka);
            return korisnik;
        }
    }
}