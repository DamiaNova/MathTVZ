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
    public partial class Registracija : System.Web.UI.Page
    {
        //Life cycle:
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //InicijalizacijaForme();
            }
        }

        //Eventi:
        protected void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (!ProvjeraIspravnostiUnosa())
            {
                var lozinka = txbLozinkaZaPrijavu.Text;
                txbLozinkaZaPrijavu.Attributes.Add("value", lozinka);
            }
            else
            {
                var db = new DBadmin();
                var registracijaSaved = db.SpremiRegistraciju(txbUsername.Text, txbLozinkaZaPrijavu.Text);

                if (registracijaSaved)
                {
                    KorisnikFactory.SpremiKorisnikaSesija(txbUsername.Text, txbLozinkaZaPrijavu.Text);
                    Response.Redirect("~\\Profil");
                }
            }
        }

        #region Metode
        public bool ProvjeraIspravnostiUnosa()
        {
            bool lozinkaOK;
            bool usernameOK;
            var db = new DBadmin();
            var korisnickoImeOK = db.ProvjeraZauzetostiImena(txbUsername.Text);

            if (txbLozinkaZaPrijavu.Text.Length < 6)
            {
                imgPozorLozinka.Attributes.Add("style", "visibility: visible");
                lblPrekratkaLozinka.Attributes.Add("style", "visibility: visible");
                txbLozinkaZaPrijavu.Attributes.Add("style", "border: 1px solid red");
                lozinkaOK = false;
            }
            else
            {
                imgPozorLozinka.Attributes.Add("style", "visibility: hidden");
                lblPrekratkaLozinka.Attributes.Add("style", "visibility: hidden");
                txbLozinkaZaPrijavu.Attributes.Add("style", "border: 1px solid rgb(211, 210, 216)");
                lozinkaOK = true;
            }

            if (txbUsername.Text.Length < 6)
            {
                imgPozorUsername.Attributes.Add("style", "visibility: visible");
                lblPrekratkoIme.Attributes.Add("style", "visibility: visible");
                txbUsername.Attributes.Add("style", "border: 1px solid red");
                usernameOK = false;
            }
            else if (!korisnickoImeOK)
            {
                imgPozorUsername.Attributes.Add("style", "visibility: visible");
                lblZauzetoIme.Attributes.Add("style", "visibility: visible");
                txbUsername.Attributes.Add("style", "border: 1px solid red");
                usernameOK = false;
            }
            else
            {
                imgPozorUsername.Attributes.Add("style", "visibility: hidden");
                lblPrekratkoIme.Attributes.Add("style", "visibility: hidden");
                lblZauzetoIme.Attributes.Add("style", "visibility: hidden");
                txbUsername.Attributes.Add("style", "border: 1px solid rgb(211, 210, 216)");
                usernameOK = true;
            }

            var OK = lozinkaOK && usernameOK;
            return OK;
        }

        public void InicijalizacijaForme()
        {
            txbUsername.Text = string.Empty;
            txbLozinkaZaPrijavu.Text = string.Empty;
            txbLozinkaZaPrijavu.Attributes.Add("border", "1px solid rgb(211, 210, 216)");
            txbUsername.Attributes.Add("border", "1px solid rgb(211, 210, 216)");
            imgPozorLozinka.Attributes.Add("style", "visibility: hidden");
            imgPozorUsername.Attributes.Add("style", "visibility: hidden");
            lblPrekratkaLozinka.Attributes.Add("style", "visibility: hidden");
            lblPrekratkoIme.Attributes.Add("style", "visibility: hidden");
            lblZauzetoIme.Attributes.Add("style", "visibility: hidden");
        }
        #endregion Metode
    }
}