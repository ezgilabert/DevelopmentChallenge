using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Reports;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class ItalianReportTests
    {
        [TestCase]
        public void TestEmptyListSummary()
        {
            // Arrange
            var language = Language.Italian;

            // Assert
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>",
                ShapeReportService.Generate(new List<Shape>(), language));
        }

        [TestCase]
        public void TestSummaryWithOneSquare()
        {
            // Arrange
            var shapes = new List<Shape> { new Square(5) };

            // Act
            var summary = ShapeReportService.Generate(shapes, Language.Italian);

            // Assert
            Assert.AreEqual("<h1>Report forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 Area 25", summary);
        }

        [TestCase]
        public void TestSummaryWithMultipleShapeTypes()
        {
            // Arrange
            var shapes = new List<Shape>
            {
                new Square(5), new Circle(3), new EquilateralTriangle(4),
                new Square(2), new EquilateralTriangle(9), new Circle(2.75m), new EquilateralTriangle(4.2m)
            };

            // Act
            var summary = ShapeReportService.Generate(shapes, Language.Italian);

            // Assert
            Assert.AreEqual(
                "<h1>Report forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 Area 91,65",
                summary);
        }
    }
}