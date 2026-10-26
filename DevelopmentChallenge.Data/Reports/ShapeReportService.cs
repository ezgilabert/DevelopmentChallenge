using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using DevelopmentChallenge.Data.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Reports
{
    public class ShapeReportService
    {
        public static string Generate(List<Shape> shapes, Language language)
        {
            var sb = new StringBuilder();

            var languageHelper = new LanguageHelper(language);
            var culture = languageHelper.GetCulture();

            if (shapes == null || !shapes.Any())
            {
                sb.Append(languageHelper.GetText(LanguageMessage.EmptyShapes));
            }
            else
            {
                sb.Append(languageHelper.GetText(LanguageMessage.ReportTitle));

                foreach (var group in shapes.GroupBy(s => s.ShapeType))
                {
                    sb.Append(BuildShapeLine(group.ToList(), languageHelper, culture));
                }

                sb.Append(languageHelper.GetText(LanguageMessage.Total));
                sb.Append(shapes.Count + " " + languageHelper.GetText(LanguageMessage.Shapes) + " ");
                sb.Append(languageHelper.GetText(LanguageMessage.Perimeter) + " " + shapes.Sum(x => x.CalculatePerimeter()).ToString("#.##", culture) + " ");
                sb.Append(languageHelper.GetText(LanguageMessage.Area) + " " + shapes.Sum(x => x.CalculateArea()).ToString("#.##", culture));
            }

            return sb.ToString().Trim();
        }

        private static string BuildShapeLine(List<Shape> shapes, LanguageHelper languageHelper, CultureInfo culture)
        {
            var count = shapes.Count;
            var area = shapes.Sum(x => x.CalculateArea());
            var perimeter = shapes.Sum(x => x.CalculatePerimeter());

            var line = count.ToString() + " " + languageHelper.GetText(LanguageMessage.ReportLine);

            return line.Replace("%SHAPE%", languageHelper.GetShapeName(shapes[0].ShapeType, count > 1))
                       .Replace("%AREA%", area.ToString("#.##", culture))
                       .Replace("%PERIMETER%", perimeter.ToString("#.##", culture));
        }
    }
}