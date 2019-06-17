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
            if (!ProvjeraUnesenihPodataka())
            {
                PostaviFormuZaNeuspjesno();
            }
            else
            {
                KorisnikFactory.StvoriKorisnika(txbKorImeEmail.Text, txbLozinkaZaPrijavu.Text);
                Response.Redirect("~\\Profil");
            }
        }

        //Metode
        public bool ProvjeraUnesenihPodataka()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
            var uspjeh = false;
            try
            {
                con.Open();
                var qry = "SELECT * FROM korisnici WHERE korisnicko_ime=@KorisnickoIme AND lozinka=@Lozinka;";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@KorisnickoIme", txbKorImeEmail.Text);
                cmd.Parameters.AddWithValue("@Lozinka", txbLozinkaZaPrijavu.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { uspjeh = true; }
                con.Close();
            }
            catch (Exception ex)
            {
                //error poruka, logiranje
            }

            return uspjeh;
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