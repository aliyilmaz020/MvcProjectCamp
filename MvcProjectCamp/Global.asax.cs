using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FluentValidation;
namespace MvcProjectCamp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_EndRequest()
        {
            if (Response.StatusCode == 401)
            {
                Response.Clear();
                Response.StatusCode = 302; // Temporary Redirect
                Response.Redirect("~/ErrorPage/Page401", true);
                Response.End();
            }
        }

    }
}
