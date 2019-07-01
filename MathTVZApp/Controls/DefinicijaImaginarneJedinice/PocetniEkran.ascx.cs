using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathTVZApp.Controls
{
    public partial class PocetniEkran : UserControl
    {
        public int BrojUserKontrole { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ucImaginarnaJedinicaJednadzba.Visible = true;
                btnNazad.Visible = false;
                btnDalje.Visible = true;
                ViewState["BrojUserKontrole"] = 0;
            }
        }

        protected void btnDalje_Click(object sender, EventArgs e)
        {
            var brKontrole = Int32.Parse(ViewState["BrojUserKontrole"].ToString());
            if(brKontrole.Equals(0))
            {
                postaviPrvuKontrolu();
            }
        }

        protected void btnNazad_Click(object sender, EventArgs e)
        {
            var brKontrole = Int32.Parse(ViewState["BrojUserKontrole"].ToString());
            if (brKontrole.Equals(1))
            {
                PostaviNultuKontrolu();
            }
        }

        private void PostaviNultuKontrolu()
        {
            ucImaginarnaJedinicaJednadzba.Visible = true;
            ucImaginarnaJedinicaDefinicija.Visible = false;
            btnNazad.Visible = false;
            btnDalje.Visible = true;
            ViewState["BrojUserKontrole"] = 0;
        }

        private void postaviPrvuKontrolu()
        {
            ucImaginarnaJedinicaJednadzba.Visible = false;
            ucImaginarnaJedinicaDefinicija.Visible = true;
            btnNazad.Visible = true;
            btnDalje.Visible = true;
            ViewState["BrojUserKontrole"] = 1;
        }
    }
}