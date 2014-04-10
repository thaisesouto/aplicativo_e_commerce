using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using projeto_e_commerce.Helpers;

namespace projeto_e_commerce
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            // Verifica se o objecto Session está pronto
            if (HttpContext.Current.Session == null)
                return;

            // O Helper criado anteriormente...
            CultureInfo ci = SessionHelper.Culture;

            // Verifica se existe valor nulo na cultura
            // e atribui a default language 
            // Isso pode acontecer na primeira requisição
            if (ci == null)
            {
                // Atribui a cultura default para o português
                string langName = "pt-BR";

                if (HttpContext.Current.
                    Request.UserLanguages != null &&
                    HttpContext.Current.
                    Request.UserLanguages.Length != 0)
                {
                    langName = HttpContext.Current.Request.
                               UserLanguages[0];
                }

                ci = new CultureInfo(langName);
                SessionHelper.Culture = ci;
            }

            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture =
                CultureInfo.CreateSpecificCulture(ci.Name);
        }

    }
}