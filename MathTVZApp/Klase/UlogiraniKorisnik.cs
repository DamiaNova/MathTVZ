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
        public int Id { get; set; }

        //članovi:
        private string _lozinka;

        //konstruktor:
        public UlogiraniKorisnik(string korisnickoIme, string lozinka)
        {
            korisnickoIme = KorisnickoIme;
            lozinka = _lozinka;
        }
    }
}