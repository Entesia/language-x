using System.Globalization;
using System.Web;
using System.Web.Routing;
using LX.Enums;

namespace LX.Infrastructure.Routing
{
    public class TranslatedRoute : Route
    {
        private const string DetectedCultureKey = "__ROUTING_DETECTED_CULTURE";

        private bool _setDetectedCulture { get; }

        private RouteValueDictionary _routeValueTranslationProviders { get; }
        public TranslatedRoute(string url, RouteValueDictionary defaults, RouteValueDictionary routeValueTranslationProviders, RouteValueDictionary constraints, bool setDetectedCulture, IRouteHandler routeHandler)
            : base(url, defaults, constraints, routeHandler)
        {
            _routeValueTranslationProviders = routeValueTranslationProviders;
            _setDetectedCulture = setDetectedCulture;
        }

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            var routeData = base.GetRouteData(httpContext);
            if (routeData == null) return null;

            foreach (var pair in _routeValueTranslationProviders)
            {
                var translationProvider = pair.Value as IRouteValueTranslationProvider;
                if (translationProvider != null
                    && routeData.Values.ContainsKey(pair.Key))
                {
                    var contentType = ContentType.Generic;

                    if (pair.Key == "controller")
                    {
                        contentType = ContentType.Controller;
                    }
                    else if (pair.Key == "action")
                    {
                        contentType = ContentType.Action;
                    }
                    var translation = translationProvider.TranslateToRouteValue(routeData.Values[pair.Key].ToString(), CultureInfo.CurrentCulture, contentType);
                    routeData.Values[pair.Key] = translation.RouteValue;

                    if (routeData.DataTokens[DetectedCultureKey] == null)
                    {
                        routeData.DataTokens.Add(DetectedCultureKey, translation.Culture);
                    }

                    if (_setDetectedCulture)
                    {
                        System.Threading.Thread.CurrentThread.CurrentCulture = translation.Culture;
                        System.Threading.Thread.CurrentThread.CurrentUICulture = translation.Culture;
                    }
                }
            }

            return routeData;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            var translatedValues = values;

            foreach (var pair in _routeValueTranslationProviders)
            {
                var translationProvider = pair.Value as IRouteValueTranslationProvider;
                if (translationProvider != null && translatedValues.ContainsKey(pair.Key))
                {
                    var contentType = ContentType.Generic;

                    if (pair.Key == "controller")
                    {
                        contentType = ContentType.Controller;
                    }
                    else if (pair.Key == "action")
                    {
                        contentType = ContentType.Action;
                    }

                    var translation = translationProvider.TranslateToRouteValue(translatedValues[pair.Key].ToString(), CultureInfo.CurrentCulture, contentType);
                    translatedValues[pair.Key] = translation.TranslatedValue;
                }
            }

            return base.GetVirtualPath(requestContext, translatedValues);
        }
    }
}