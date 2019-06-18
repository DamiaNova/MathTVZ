using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using MathTVZApp.Klase;

namespace MathTVZApp.Ekrani
{
    public partial class Prijava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //DoNothing();
            }
        }

        //Eventi:
        protected void btnPrijava_Click(object sender, EventArgs e)
        {
            var db = new DBadmin();
            var provjera = db.ProvjeraPrijave(txbKorImeEmail.Text, txbLozinkaZaPrijavu.Text);

            if (!provjera)
            {
                PostaviFormuZaNeuspjesno();
            }
            else
            {
                KorisnikFactory.SpremiKorisnikaSesija(txbKorImeEmail.Text, txbLozinkaZaPrijavu.Text);
                Response.Redirect("~\\Profil");
            }
        }

        private void PostaviFormuZaNeuspjesno()
        {
            imgPozorLozinka.Attributes.Add("style", "visibility: visible");
            imgPozorUsername.Attributes.Add("style", "visibility: visible");
            NeuspjesnaPrijava.Attributes.Add("style", "visibility: visible");
            var lozinka = txbLozinkaZaPrijavu.Text;
            txbLozinkaZaPrijavu.Attributes.Add("value", lozinka);
        }
    }
}