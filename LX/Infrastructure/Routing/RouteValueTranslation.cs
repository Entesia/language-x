using System.Globalization;
using LX.Enums;

namespace LX.Infrastructure.Routing
{
    public class RouteValueTranslation
    {
        public CultureInfo Culture { get; set; }
        public string RouteValue { get; set; }
        public string TranslatedValue { get; set; }
        public ContentType Type { get; set; }
    }
}