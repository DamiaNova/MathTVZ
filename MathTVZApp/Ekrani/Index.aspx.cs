using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MathTVZApp.Klase;

namespace MathTVZApp.Ekrani
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (isKorisnikUlogiran())
            {
                PostaviČlanakZaKorisnika();
            }
            else
            {
                PostaviČlanakZaGosta();
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

        private void PostaviČlanakZaKorisnika()
        {
            btnRegistracija.Text = "Trening";
            btnRegistracija.PostBackUrl = "~\\Trening";
            lblRegistracijaTrening.Text = "Želiš sakupiti bodove?";
        }

        private void PostaviČlanakZaGosta()
        {
            btnRegistracija.Text = "Registracija";
            btnRegistracija.PostBackUrl = "~\\Registracija";
            lblRegistracijaTrening.Text = "Želiš nam se pridružiti?";
        }
    }
}