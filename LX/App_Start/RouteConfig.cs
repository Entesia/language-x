using System.Web.Mvc;
using System.Web.Routing;
using LX.Infrastructure.Routing;

namespace LX
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            var translatedControllerRouts = Translations.TranslatedCollection;

            routes.MapRoute(
                name: "notFound",
                url: "not-found",
                defaults: new { controller = "Home", action = "PageNotFound", id = UrlParameter.Optional }
            );

            routes.MapTranslatedRoute(
                "TranslatedRoute",
                "{lang}/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = string.Empty },
                new { controller = translatedControllerRouts, action = translatedControllerRouts },
                new { lang = @"[a-z]{2}-[a-z]{2}" },
                true
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Base", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}