using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace MathTVZApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Dodavanje prilagođenih URL-ova za ekrane
            RegisterCustomRoutes(RouteTable.Routes);
        }

        void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("PocetnaStranica","","~/Ekrani/Index.aspx");
            routes.MapPageRoute("Registracija", "Registracija", "~/Ekrani/Registracija.aspx");
            routes.MapPageRoute("Prijava", "Prijava", "~/Ekrani/Prijava.aspx");
            routes.MapPageRoute("Profil", "Profil", "~/Ekrani/Profil.aspx");
            routes.MapPageRoute("Trening", "Trening", "~/Ekrani/Trening.aspx");
            routes.MapPageRoute("Lekcije", "Lekcije", "~/Ekrani/Lekcije.aspx");
            routes.MapPageRoute("Kvizovi", "Kvizovi", "~/Ekrani/Kvizovi.aspx");
            routes.MapPageRoute("Derivacije", "Kvizovi/Derivacije", "~/Ekrani/Derivacije.aspx");
            routes.MapPageRoute("404PageNotFound", "404", "~/Ekrani/404PageNotFound.aspx");
        }
    }
}