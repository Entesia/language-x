using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using LX.Enums;

namespace LX.Infrastructure.Routing
{
    public class Translations
    {
        public static readonly CultureInfo EnCulture = CultureInfo.GetCultureInfo("en-gb");
        public static readonly CultureInfo DeCulture = CultureInfo.GetCultureInfo("de-de");
        public static readonly CultureInfo FrCulture = CultureInfo.GetCultureInfo("fr-fr");
        public static readonly CultureInfo ItCulture = CultureInfo.GetCultureInfo("it-it");
        public static readonly CultureInfo SpCulture = CultureInfo.GetCultureInfo("es-es");
        public static readonly CultureInfo NlCulture = CultureInfo.GetCultureInfo("nl-nl");
        public static readonly CultureInfo PlCulture = CultureInfo.GetCultureInfo("pl-pl");
        public static readonly CultureInfo RoCulture = CultureInfo.GetCultureInfo("ro-ro");
        public static readonly CultureInfo RuCulture = CultureInfo.GetCultureInfo("ru-ru");
        public static readonly CultureInfo TrCulture = CultureInfo.GetCultureInfo("tr-tr");

        public static DictionaryRouteValueTranslationProvider TranslatedCollection = new DictionaryRouteValueTranslationProvider(new List<RouteValueTranslation>());

        public static string Translate(string value, ContentType type, string language = "")
        {
            var langs = new List<string> { "en-gb", "de-de", "fr-fr", "it-it", "es-es", "nl-nl", "pl-pl", "ro-ro", "ru-ru", "tr-tr" };

            var lang = HttpContext.Current.Request.Cookies["Lang"];

            var culture = langs[0];
            if (lang != null)
            {
                culture = lang.Value;
                if (!langs.Contains(lang.Value))
                {
                    culture = langs[0];
                }
            }
            if (!string.IsNullOrEmpty(language))
            {
                culture = language;
            }
            var result = TranslatedCollection.Translations.FirstOrDefault(r => r.Culture.ToString().ToLower() == culture && r.Type == type && r.RouteValue == value);
            if (result != null)
            {
                return result.TranslatedValue;
            }
            return value;
        }

        public static string Translate(string lang, ContentType[] types, string value)
        {
            var translatedValue = TranslatedCollection.Translations.FirstOrDefault(r => (types.Any(p => p == r.Type)) && String.Equals(value, r.TranslatedValue, StringComparison.CurrentCultureIgnoreCase));
            if (translatedValue != null)
            {
                var result = TranslatedCollection.Translations.FirstOrDefault(r => r.Culture.ToString().ToLower() == lang.ToLower()
                                                                                   && (types.Any(p => p == r.Type)) && translatedValue.RouteValue == r.RouteValue);
                return result != null ? result.TranslatedValue : value;
            }
            return value;
        }
    }
}