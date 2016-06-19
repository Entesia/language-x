using System.Globalization;
using LX.Enums;

namespace LX.Infrastructure.Routing
{
    public interface IRouteValueTranslationProvider
    {
        RouteValueTranslation TranslateToRouteValue(string translatedValue, CultureInfo culture, ContentType contentType);
    }
}