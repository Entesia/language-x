using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using LX.Infrastructure.Routing;
using LX.Infrastructure;

namespace LX
{
    public class MvcApplication : HttpApplication
    {
        public static Dictionary<string, string> Cache { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            Translations.TranslatedCollection = new DictionaryRouteValueTranslationProvider((new LocalizationService().GetAll()).Select(r => new RouteValueTranslation
            {
                Culture = new CultureInfo(r.Culture),
                RouteValue = r.Name,
                TranslatedValue = r.Value,
                Type = r.ContentType
            }).ToList());

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (ex is HttpException && ((HttpException)ex).GetHttpCode() == 404)
            {
                Response.Redirect("not-found");
            }
        }   
    }
}