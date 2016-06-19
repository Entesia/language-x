using System;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LX.Enums;
using LX.Infrastructure.Routing;

namespace LX.Infrastructure
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString LanguageDropdown(this HtmlHelper helper)
        {
            string absolutePath = HttpContext.Current.Request.Url.LocalPath;
            string query = HttpContext.Current.Request.Url.Query;


            var table = @"<div role='tabpanel'><ul id='language' class='nav nav-tabs' role='tablist'>";
            foreach (var lang in Enum.GetValues(typeof(Language)))
            {
                var culture = "";
                var icon = "";
                switch ((Language)lang)
                {
                    case Language.German:
                        culture = Translations.DeCulture.Name.ToLower();
                        icon = "flag-DE";
                        break;
                    case Language.English:
                        culture = Translations.EnCulture.Name.ToLower();
                        icon = "flag-GB";
                        break;
                    case Language.Spanish:
                        culture = Translations.SpCulture.Name.ToLower();
                        icon = "flag-ES";
                        break;
                    case Language.French:
                        culture = Translations.FrCulture.Name.ToLower();
                        icon = "flag-FR";
                        break;
                    case Language.Italian:
                        culture = Translations.ItCulture.Name.ToLower();
                        icon = "flag-IT";
                        break;
                    case Language.Dutch:
                        culture = Translations.NlCulture.Name.ToLower();
                        icon = "flag-NL";
                        break;
                    case Language.Polish:
                        culture = Translations.PlCulture.Name.ToLower();
                        icon = "flag-PL";
                        break;
                    case Language.Romanian:
                        culture = Translations.RoCulture.Name.ToLower();
                        icon = "flag-RO";
                        break;
                    case Language.Russian:
                        culture = Translations.RuCulture.Name.ToLower();
                        icon = "flag-RU";
                        break;
                    case Language.Turkish:
                        culture = Translations.TrCulture.Name.ToLower();
                        icon = "flag-TR";
                        break;

                }

                var value = lang.GetType().GetField(lang.ToString());
                var attributes = (DescriptionAttribute[])value.GetCustomAttributes(typeof(DescriptionAttribute), false);

                var elem = attributes.Any() ? attributes.First().Description : lang.ToString();
                var paths = absolutePath.Split('/');
                string url = "/" + culture;
                foreach (var path in paths.Skip(2))
                {
                    url += "/" + Translations.Translate(culture, new[] { ContentType.Action, ContentType.Controller }, path);
                }

                url += string.IsNullOrEmpty(query) ? "" : query;
                table += string.Format("<li class='localization' role='presentation'><a aria-controls='' role='tab' data-toggle='tab' href='{0}' data-lang='{1}'><i class='{2}'></i>{3}</a></li>", url, culture, icon, elem);
            }

            table += "</ul></div>";
            return new MvcHtmlString(table);
        }

        public static MvcHtmlString LanguageDesc(this HtmlHelper helper)
        {
            var culture = HttpContext.Current.Request.Cookies["Lang"];

            string lang = culture != null ? culture.Value.Split('-').First().ToLower() : "en";

            var langDesc = ""; 
            switch (lang)
            {
                case "en":
                    langDesc = "<i class='flag-GB'></i> English";
                    break;
                case "de":
                    langDesc = "<i class='flag-DE'></i> Deutsch";
                    break;
                case "fr":
                    langDesc = "<i class='flag-FR'></i> Français";
                    break;
                case "it":
                    langDesc = "<i class='flag-IT'></i> Italiano";
                    break;
                case "es":
                    langDesc = "<i class='flag-ES'></i> Español";
                    break;
                case "nl":
                    langDesc = "<i class='flag-NL'></i> Nederlands";
                    break;
                case "pl":
                    langDesc = "<i class='flag-PL'></i> Polski";
                    break;
                case "ro":
                    langDesc = "<i class='flag-RO'></i> Română";
                    break;
                case "ru":
                    langDesc = "<i class='flag-RU'></i> Pусский";
                    break;
                case "tr":
                    langDesc = "<i class='flag-TR'></i> Türkçe";
                    break;
            }

            return new MvcHtmlString(langDesc);
        }

        public static MvcHtmlString LanguageUrl(this HtmlHelper helper)
        {
            var url = string.Format("/{0}/{1}/{2}", Current.LangCode, Translations.Translate("Search", ContentType.Controller), Translations.Translate("Index", ContentType.Action));
            return new MvcHtmlString(url);
        }
        public static MvcHtmlString Back(this HtmlHelper helper)
        {
            var url = string.Format("/{0}/{1}/{2}", Current.LangCode, Translations.Translate("Home", ContentType.Controller), Translations.Translate("Index", ContentType.Action));
            return new MvcHtmlString(url);
        }
    }
}
