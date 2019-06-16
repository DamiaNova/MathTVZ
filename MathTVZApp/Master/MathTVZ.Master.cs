using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MathTVZApp.Klase;

namespace MathTVZApp
{
    public partial class MathTVZ : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (isKorisnikUlogiran())
            {
                PostaviNavigacijuZaKorisnika();
            }
            else
            {
                PostaviNavigacijuZaGosta();
            }
        }

        private bool isKorisnikUlogiran()
        {
            var OK = true;
            var korisnik = (UlogiraniKorisnik)Session["UlogiraniKorisnik"];

            if (korisnik == null)
            {
                OK = false;
            }

            return OK;
        }

        private void PostaviNavigacijuZaKorisnika()
        {
            lnkPrijavaTrening.Text = "Trening";
            lnkPrijavaTrening.NavigateUrl = "~\\Trening";
            lnkRegistracijaProfil.Text = "Moj profil";
            lnkRegistracijaProfil.NavigateUrl = "~\\Profil";
        }

        private void PostaviNavigacijuZaGosta()
        {
            lnkPrijavaTrening.Text = "Prijava";
            lnkPrijavaTrening.NavigateUrl = "~\\Prijava";
            lnkRegistracijaProfil.Text = "Registracija";
            lnkRegistracijaProfil.NavigateUrl = "~\\Registracija";
        }
    }
}