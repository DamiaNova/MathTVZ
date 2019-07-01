using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathTVZApp.Controls.DefinicijaImaginarneJedinice
{
    public partial class ImaginarnaJedinicaDefinicija : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProvjeriPrvi_Click(object sender, EventArgs e)
        {
            var unosPrvi = txbPrviOdgovor.Text;
            if (unosPrvi.Length.Equals(0))
            {
                PrviJePrazan();
            }
            else if (unosPrvi == "-i" || unosPrvi == "i")
            {
                PrviJeOK();
            }
            else if (unosPrvi != "-i" && unosPrvi != "i")
            {
                PrviNijeOK();
            }
        }

        protected void btnProvjeriDrugi_Click(object sender, EventArgs e)
        {
            var unosDrugi = txbDrugiOdgovor.Text;
            if (unosDrugi.Length.Equals(0))
            {
                DrugiJePrazan();
            }
            else if (unosDrugi == "-i" || unosDrugi == "i")
            {
                DrugiJeOK();
            }
            else if (unosDrugi != "-i" && unosDrugi != "i")
            {
                DrugiNijeOK();
            }
        }

        protected void btnRjesenja_Click(object sender, EventArgs e)
        {
            PrviJeOK();
            DrugiJeOK();
            txbPrviOdgovor.Text = "i";
            txbDrugiOdgovor.Text = "-i";
        }

        private void PrviJeOK()
        {
            imgPozorPrvi.Src = "~\\Slike\\ok.png";
            imgPozorPrvi.Attributes.Add("style", "visibility: visible");
            lblPrviOdg.Attributes.Add("style", "visibility: visible; color: lawngreen");
            lblPrviOdg.Text = "Točno";
        }

        private void PrviNijeOK()
        {
            imgPozorPrvi.Src = "~\\Slike\\pozor.png";
            imgPozorPrvi.Attributes.Add("style", "visibility: visible");
            lblPrviOdg.Attributes.Add("style", "visibility: visible; color: red");
            lblPrviOdg.Text = "Netočno";
        }

        private void PrviJePrazan()
        {
            imgPozorPrvi.Src = "~\\Slike\\pozor.png";
            imgPozorPrvi.Attributes.Add("style", "visibility: visible");
            lblPrviOdg.Attributes.Add("style", "visibility: visible; color: red");
            lblPrviOdg.Text = "Molimo unesite odgovor!";
        }

        private void DrugiJePrazan()
        {
            imgPozorDrugi.Src = "~\\Slike\\pozor.png";
            imgPozorDrugi.Attributes.Add("style", "visibility: visible");
            lblDrugiOdg.Attributes.Add("style", "visibility: visible; color: red");
            lblDrugiOdg.Text = "Molimo unesite odgovor!";
        }

        private void DrugiJeOK()
        {
            imgPozorDrugi.Src = "~\\Slike\\ok.png";
            imgPozorDrugi.Attributes.Add("style", "visibility: visible");
            lblDrugiOdg.Attributes.Add("style", "visibility: visible; color: lawngreen");
            lblDrugiOdg.Text = "Točno";
        }

        private void DrugiNijeOK()
        {
            imgPozorDrugi.Src = "~\\Slike\\pozor.png";
            imgPozorDrugi.Attributes.Add("style", "visibility: visible");
            lblDrugiOdg.Attributes.Add("style", "visibility: visible; color: red");
            lblDrugiOdg.Text = "Netočno";
        }
    }
}