using System.Collections.Generic;

namespace AutomaticClick.Models
{
    public class TranslationItem
    {
        public int Group { get; set; }
        public DetectedLanguage detectedLanguage { get; set; }
        public List<Translations> translations { get; set; }
    }

    public class DetectedLanguage
    {
        public string Language { get; set; }
        public double Score { get; set; }
    }

    public class Translations
    {
        public string Text { get; set; }
        public string To { get; set; }
    }
}