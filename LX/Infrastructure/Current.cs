using System.Web;
using System.Collections.Generic;
using System.Linq;
using LX.Enums;
using LX.Models;

namespace LX.Infrastructure
{
    public class Current
    {
        private static readonly List<LanguageModel> languages = new List<LanguageModel>
                            {
                                   new LanguageModel(Language.English, "en-gb"),
                                   new LanguageModel(Language.German, "de-de"),
                                   new LanguageModel(Language.French, "fr-fr"),
                                   new LanguageModel(Language.Italian, "it-it"),
                                   new LanguageModel(Language.Spanish, "es-es"),
                                   new LanguageModel(Language.Dutch, "nl-nl"),
                                   new LanguageModel(Language.Polish, "pl-pl"),
                                   new LanguageModel(Language.Romanian, "ro-ro"),
                                   new LanguageModel(Language.Russian, "ru-ru"),
                                   new LanguageModel(Language.Turkish, "tr-tr")
                            };
        public static Language Culture
        {
            get
            {
                var langs = languages;

                if (HttpContext.Current != null)
                {
                    var lang = HttpContext.Current.Request.Cookies["Lang"];
                    if (lang != null)
                    {
                        var localization = langs.FirstOrDefault(r => r.Code == lang.Value);
                        if (localization != null)
                        {
                            return localization.Language;
                        }
                    }
                }
                return Language.English;
            }
        }

        public static List<LanguageModel> Languages
        {
            get { return languages; }
        }

        public static string LangCode
        {
            get
            {
                var lang = HttpContext.Current.Request.Cookies["Lang"];
                if (lang != null)
                {
                    return lang.Value;
                }
                return string.Empty;
            }
        }
    }
}