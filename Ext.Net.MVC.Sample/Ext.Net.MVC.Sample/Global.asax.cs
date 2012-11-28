using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ext.Net.MVC.Sample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_AuthenticateRequest(object sender, System.EventArgs e)
        {
            string url = HttpContext.Current.Request.FilePath;

            // Skip all ext.axd embedded resources
            if (url.EndsWith("ext.axd"))
            {
                HttpContext.Current.SkipAuthorization = true;
            }
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            // Ignore all ext.axd embedded resource paths
            routes.IgnoreRoute("{exclude}/{extnet}/ext.axd");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "ExtNet", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }
}