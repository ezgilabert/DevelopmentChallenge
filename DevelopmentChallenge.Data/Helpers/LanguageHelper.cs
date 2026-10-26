using DevelopmentChallenge.Data.Enums;
using System;
using System.Globalization;
using System.Resources;

namespace DevelopmentChallenge.Data.Helpers
{
    public class LanguageHelper
    {
        private readonly ResourceManager _resourceManager = new ResourceManager("DevelopmentChallenge.Data.Resources.Strings", typeof(LanguageHelper).Assembly);
        private readonly Language _language;

        public LanguageHelper(Language language)
        {
            _language = language;
        }

        public string GetText(LanguageMessage messageEnum)
        {
            return _resourceManager.GetString(messageEnum.ToString(), GetCulture()) ?? string.Empty;
        }

        public CultureInfo GetCulture()
        {
            switch (_language)
            {
                case Language.Spanish: return CultureInfo.GetCultureInfo("es-ES");
                case Language.English: return CultureInfo.GetCultureInfo("en-US");
                case Language.Italian: return CultureInfo.GetCultureInfo("it-IT");
                default: throw new ArgumentOutOfRangeException(nameof(_language), _language, "Unsupported language.");
            }
        }

        public string GetShapeName(ShapeType shapeType, bool plural)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return plural ? GetText(LanguageMessage.Circles) : GetText(LanguageMessage.Circle);
                case ShapeType.Square:
                    return plural ? GetText(LanguageMessage.Squares) : GetText(LanguageMessage.Square);
                case ShapeType.Rectangle:
                    return plural ? GetText(LanguageMessage.Rectangles) : GetText(LanguageMessage.Rectangle);
                case ShapeType.Trapezoid:
                    return plural ? GetText(LanguageMessage.Trapezoids) : GetText(LanguageMessage.Trapezoid);
                case ShapeType.EquilateralTriangle:
                    return plural ? GetText(LanguageMessage.Triangles) : GetText(LanguageMessage.Triangle);
                default:
                    throw new ArgumentException("Invalid shape type", nameof(shapeType));
            }
        }
    }
}