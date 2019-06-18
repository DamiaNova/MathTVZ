using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathTVZApp.Klase
{
    public class UlogiraniKorisnik
    {
        //svojstva:
        public string KorisnickoIme { get; set; }
        public string KorisnikId { get; set; }
        public string Lozinka { get; set; }

        //konstruktor:
        public UlogiraniKorisnik(string korisnickoIme, string lozinka, string id)
        {
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            KorisnikId = id;
        }
    }
}