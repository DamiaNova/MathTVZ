using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

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
                if (SpremiRegistraciju())
                {
                    InicijalizacijaForme();
                    //redirekcija na početnu dobrodošli stranicu
                }
            }
        }

        //Metode:
        public bool ProvjeraIspravnostiUnosa()
        {
            bool lozinkaOK;
            bool usernameOK;

            if (txbLozinkaZaPrijavu.Text.Length < 6)
            {
                imgPozorLozinka.Attributes.Add("style", "visibility: visible");
                txbLozinkaZaPrijavu.Attributes.Add("style", "border: 1px solid red");
                lozinkaOK = false;
            }
            else
            {
                imgPozorLozinka.Attributes.Add("style", "visibility: hidden");
                txbLozinkaZaPrijavu.Attributes.Add("style", "border: 1px solid rgb(211, 210, 216)");
                lozinkaOK = true;
            }

            if (txbUsername.Text.Length < 6)
            {
                imgPozorUsername.Attributes.Add("style", "visibility: visible");
                txbUsername.Attributes.Add("style", "border: 1px solid red");
                usernameOK = false;
            }
            else
            {
                imgPozorUsername.Attributes.Add("style", "visibility: hidden");
                txbUsername.Attributes.Add("style", "border: 1px solid rgb(211, 210, 216)");
                usernameOK = true;
            }

            var OK = lozinkaOK && usernameOK;
            return OK;
        }

        public bool SpremiRegistraciju()
        {
            SqlConnection con = new SqlConnection();
            var spremljeno = false;
            con.ConnectionString =
                "Server=localhost;" +
                "Database=MathTVZ;" +
                "Trusted_Connection=True;";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into korisnici values(@KorisnickoIme, @Lozinka)", con);
                cmd.Parameters.AddWithValue("KorisnickoIme", txbUsername.Text);
                cmd.Parameters.AddWithValue("Lozinka", txbLozinkaZaPrijavu.Text);
                cmd.ExecuteNonQuery();
                spremljeno = true;
            }
            catch (Exception)
            {
                //logiranje
            }

            return spremljeno;
        }

        public void InicijalizacijaForme()
        {
            txbUsername.Text = string.Empty;
            txbLozinkaZaPrijavu.Text = string.Empty;
            txbLozinkaZaPrijavu.Attributes.Add("border", "1px solid rgb(211, 210, 216)");
            txbUsername.Attributes.Add("border", "1px solid rgb(211, 210, 216)");
            imgPozorLozinka.Attributes.Add("style", "visibility: hidden");
            imgPozorUsername.Attributes.Add("style", "visibility: hidden");
        }
    }
}