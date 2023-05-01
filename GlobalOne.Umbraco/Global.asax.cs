using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GlobalOne.Umbraco
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        private void application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            try
            {
                if (Session != null && Session.IsNewSession)
                {
                    // Your code here
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
                }
            }
            catch (Exception ex) { }
        }
    }
}
