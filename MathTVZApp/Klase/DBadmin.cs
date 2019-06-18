using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MathTVZApp.Klase
{
    public class DBadmin : DBpristup
    {
        public bool ProvjeraPrijave(string username, string lozinka)
        {
            base.Username = username;
            base.Lozinka = lozinka;
            base.ProvjeraPrijaveKorisnika();
            return base.OK;
        }

        public bool ProvjeraZauzetostiImena(string username)
        {
            base.Username = username;
            base.ProvjeraZauzetostiImena();
            return base.OK;
        }

        public bool SpremiRegistraciju(string username, string lozinka)
        {
            base.Username = username;
            base.Lozinka = lozinka;
            base.SpremiRegistraciju();
            return base.OK;
        }
    }
}