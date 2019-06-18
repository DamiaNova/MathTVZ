using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MathTVZApp.Klase;

namespace MathTVZApp.Ekrani
{
    public partial class Trening : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnKvizovi_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Kvizovi");
        }

        protected void btnZadaci_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Zadaci");
        }

        protected void btnPripreme_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Pripreme");
        }
    }
}