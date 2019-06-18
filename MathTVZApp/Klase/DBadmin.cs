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
    }
}