using System.Web.Mvc;
using System.Web.Routing;

namespace LX.Infrastructure.Routing
{
    public static class TranslatedRouteCollectionExtensions
    {
        public static void MapTranslatedRoute(this RouteCollection routes, string name, string url, object defaults,
                                object routeValueTranslationProviders, object constraints, bool setDetectedCulture)
        {
            var route = new TranslatedRoute(url, new RouteValueDictionary(defaults),
                                    new RouteValueDictionary(routeValueTranslationProviders),
                                    new RouteValueDictionary(constraints),
                                    setDetectedCulture, new MvcRouteHandler());
            routes.Add(name, route);
        }
    }
}