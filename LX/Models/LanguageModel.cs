using LX.Enums;

namespace LX.Models
{
    public class LanguageModel
    {
        public Language Language { get; set; }
        public string Code { get; set; }
        public string ShortCode { get; set; }

        public LanguageModel() { }

        public LanguageModel(Language language, string code)
        {
            Language = language;
            Code = code;
            ShortCode = code.Split('-')[0];
        }
    }
}