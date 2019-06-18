using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MathTVZApp.Klase;

namespace MathTVZApp.Ekrani
{
    public partial class Profil : System.Web.UI.Page
    {
        public string UkupanBrojBodova { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (isKorisnikUlogiran())
            {
                PostaviNavigacijuZaKorisnika();
                PostaviBrojBodova();
                PostaviOdgovarajućuMedalju();
            }
            else
            {
                PostaviNavigacijuZaGosta();
            }
        }

        //Eventi:
        protected void btnOdjava_Click(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Session["UlogiraniKorisnik"] = null;
            Response.Redirect("~\\");
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

        private void PostaviBrojBodova()
        {
            var korisnik = (UlogiraniKorisnik)Session["UlogiraniKorisnik"];
            var db = new DBadmin();
            var id = korisnik.KorisnikId;
            var brBodova = db.GetBrojBodova(id);

            lblBrojBodova.Text = brBodova;
            ViewState["UkupanBrojBodova"] = brBodova;
        }

        private void PostaviOdgovarajućuMedalju()
        {
            var brBodova = Int32.Parse(ViewState["UkupanBrojBodova"].ToString());

            if(brBodova <= 50) { imgBronze.Attributes.Add("style", "visibility: visible"); }
            else if(brBodova > 50 && brBodova <= 100) { imgSilver.Attributes.Add("style", "visibility: visible"); }
            else if (brBodova > 100 && brBodova <= 150) { imgGold.Attributes.Add("style", "visibility: visible"); }
            else { imgDiamond.Attributes.Add("style", "visibility: visible"); }
        }
    }
}