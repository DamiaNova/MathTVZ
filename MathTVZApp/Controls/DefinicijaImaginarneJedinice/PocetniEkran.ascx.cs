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
                PostaviPrvuKontrolu();
            }
            else if (brKontrole.Equals(1))
            {
                PostaviTrecuKontrolu();
            }
        }

        protected void btnNazad_Click(object sender, EventArgs e)
        {
            var brKontrole = Int32.Parse(ViewState["BrojUserKontrole"].ToString());
            if (brKontrole.Equals(1))
            {
                PostaviNultuKontrolu();
            }
            else if (brKontrole.Equals(2))
            {
                PostaviPrvuKontrolu();
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

        private void PostaviTrecuKontrolu()
        {
            ucImaginarnaMiniKviz.Visible = true;
            ucImaginarnaJedinicaDefinicija.Visible = false;
            ucImaginarnaJedinicaJednadzba.Visible = false;
            btnNazad.Visible = true;
            btnDalje.Visible = false;
            ViewState["BrojUserKontrole"] = 2;
        }

        private void PostaviPrvuKontrolu()
        {
            ucImaginarnaJedinicaJednadzba.Visible = false;
            ucImaginarnaMiniKviz.Visible = false;
            ucImaginarnaJedinicaDefinicija.Visible = true;
            btnNazad.Visible = true;
            btnDalje.Visible = true;
            ViewState["BrojUserKontrole"] = 1;
        }
    }
}