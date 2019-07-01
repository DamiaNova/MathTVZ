using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathTVZApp.Controls.DefinicijaImaginarneJedinice
{
    public partial class ImaginarnaMiniKviz : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRjesenja_Click(object sender, EventArgs e)
        {
            //UkloniSveDotadašnje();
            PostaviSveNaZeleno();
        }

        protected void btnProvjeri_Click(object sender, EventArgs e)
        {
            ProvjeriPrvoPitanje();
            ProvjeriDrugoPitanje();
            ProvjeriTrecePitanje();
            ProvjeriCetvrtoPitanje();
        }

        protected void btnOcisti_Click(object sender, EventArgs e)
        {
            UkloniSveDotadašnje();
        }

        private void UkloniSveDotadašnje()
        {
            imgTocnoPrvo.Visible = false;
            imgTocnoDrugo.Visible = false;
            imgTreceTocno.Visible = false;
            imgTocnoCetvrto.Visible = false;
            txbPrviOdgovor.Text = string.Empty;
            lblPrviOdgKviz.Visible = false;
            lblDrugiOdgKviz.Visible = false;
            lblTreciOdgKviz.Visible = false;
            lblCetvrtiOdgKviz.Visible = false;
            rblImaginarnaJedinica.ClearSelection();
            rblSkupRealnih.ClearSelection();
            rblNema.ClearSelection();
        }

        private void PostaviSveNaZeleno()
        {
            imgTocnoPrvo.Visible = true;
            imgTocnoDrugo.Visible = true;
            imgTreceTocno.Visible = true;
            imgTocnoCetvrto.Visible = true;
            lblPrviOdgKviz.Visible = true;
            lblDrugiOdgKviz.Visible = true;
            lblTreciOdgKviz.Visible = true;
            lblCetvrtiOdgKviz.Visible = true;
            imgTocnoPrvo.Src = "~\\Slike\\ok.png";
            imgTocnoDrugo.Src = "~\\Slike\\ok.png";
            imgTreceTocno.Src = "~\\Slike\\ok.png";
            imgTocnoCetvrto.Src = "~\\Slike\\ok.png";
            txbPrviOdgovor.Text = "-1";
            lblPrviOdgKviz.Attributes.Add("style", "color: lawngreen");
            lblPrviOdgKviz.Text = "Točno";
            lblDrugiOdgKviz.Attributes.Add("style", "color: lawngreen");
            lblDrugiOdgKviz.Text = "Točno";
            lblTreciOdgKviz.Attributes.Add("style", "color: lawngreen");
            lblTreciOdgKviz.Text = "Točno";
            lblCetvrtiOdgKviz.Attributes.Add("style", "color: lawngreen");
            lblCetvrtiOdgKviz.Text = "Točno";
            rblImaginarnaJedinica.SelectedIndex = 0;
            rblSkupRealnih.SelectedIndex = 0;
            rblNema.SelectedIndex = 1;
        }

        private void ProvjeriPrvoPitanje()
        {
            var prviOdgovor = txbPrviOdgovor.Text;
            if (prviOdgovor.Length.Equals(0))
            {
                imgTocnoPrvo.Visible = false;
                lblPrviOdgKviz.Visible = false;
            }
            else if (prviOdgovor == "-1")
            {
                imgTocnoPrvo.Visible = true;
                lblPrviOdgKviz.Visible = true;
                imgTocnoPrvo.Src = "~\\Slike\\ok.png";
                lblPrviOdgKviz.Attributes.Add("style", "color: lawngreen");
                lblPrviOdgKviz.Text = "Točno";
            }
            else if (prviOdgovor != "-1")
            {
                imgTocnoPrvo.Visible = true;
                lblPrviOdgKviz.Visible = true;
                imgTocnoPrvo.Src = "~\\Slike\\pozor.png";
                lblPrviOdgKviz.Attributes.Add("style", "color: red");
                lblPrviOdgKviz.Text = "Netočno";
            }
        }

        private void ProvjeriDrugoPitanje()
        {
            var drugiOdgovor = rblImaginarnaJedinica.SelectedIndex;
            if (drugiOdgovor.Equals(0))
            {
                imgTocnoDrugo.Visible = true;
                lblDrugiOdgKviz.Visible = true;
                imgTocnoDrugo.Src = "~\\Slike\\ok.png";
                lblDrugiOdgKviz.Attributes.Add("style", "color: lawngreen");
                lblDrugiOdgKviz.Text = "Točno";
            }
            else
            {
                imgTocnoDrugo.Visible = false;
                lblDrugiOdgKviz.Visible = false;
            }
        }

        private void ProvjeriTrecePitanje()
        {
            var treciOdgovor = rblSkupRealnih.SelectedIndex;
            if (treciOdgovor.Equals(0))
            {
                imgTreceTocno.Visible = true;
                lblTreciOdgKviz.Visible = true;
                imgTreceTocno.Src = "~\\Slike\\ok.png";
                lblTreciOdgKviz.Attributes.Add("style", "color: lawngreen");
                lblTreciOdgKviz.Text = "Točno";
            }
            else
            {
                imgTreceTocno.Visible = false;
                lblTreciOdgKviz.Visible = false;
            }
        }

        private void ProvjeriCetvrtoPitanje()
        {
            var cetvrtiOdgovor = rblNema.SelectedIndex;
            if (cetvrtiOdgovor.Equals(1))
            {
                imgTocnoCetvrto.Visible = true;
                lblCetvrtiOdgKviz.Visible = true;
                imgTocnoCetvrto.Src = "~\\Slike\\ok.png";
                lblCetvrtiOdgKviz.Attributes.Add("style", "color: lawngreen");
                lblCetvrtiOdgKviz.Text = "Točno";
            }
            else
            {
                imgTocnoCetvrto.Visible = false;
                lblCetvrtiOdgKviz.Visible = false;
            }
        }
    }
}