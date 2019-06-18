using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathTVZApp.Ekrani
{
    public partial class Kvizovi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPovratak_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Trening");
        }

        protected void btnDerivacije_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Kvizovi\\Derivacije");
        }
    }
}