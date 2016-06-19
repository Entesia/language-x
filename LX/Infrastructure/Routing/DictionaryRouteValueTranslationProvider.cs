using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using LX.Enums;

namespace LX.Infrastructure.Routing
{
    public class DictionaryRouteValueTranslationProvider : IRouteValueTranslationProvider
    {
        public IList<RouteValueTranslation> Translations { get; }

        public DictionaryRouteValueTranslationProvider(IList<RouteValueTranslation> translations)
        {
            Translations = translations;
        }

        public RouteValueTranslation TranslateToRouteValue(string translatedValue, CultureInfo culture, ContentType contentType)
        {
            var translation = Translations.FirstOrDefault(t => t.TranslatedValue == translatedValue
                && (t.Culture.ToString() == culture.ToString() || t.Culture.ToString().Substring(0, 2) == culture.ToString().Substring(0, 2)) && t.Type == contentType);

            if (translation != null)
            {
                return translation;
            }

            translation = Translations.FirstOrDefault(t => t.TranslatedValue == translatedValue && t.Type == contentType);
            if (translation != null)
            {
                return translation;
            }

            return new RouteValueTranslation
            {
                Culture = culture,
                RouteValue = translatedValue,
                TranslatedValue = translatedValue
            };
        }
    }
}