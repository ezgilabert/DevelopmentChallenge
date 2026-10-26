using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Reports;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class SpanishReportTests
    {
        [TestCase]
        public void TestEmptyListSummary()
        {
            // Arrange
            var language = Language.Spanish;

            // Assert
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ShapeReportService.Generate(new List<Shape>(), language));
        }

        [TestCase]
        public void TestSummaryWithOneSquare()
        {
            // Arrange
            var shapes = new List<Shape> { new Square(5) };

            // Act
            var summary = ShapeReportService.Generate(shapes, Language.Spanish);

            // Assert
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", summary);
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
            var summary = ShapeReportService.Generate(shapes, Language.Spanish);

            // Assert
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                summary);
        }

        [TestCase]
        public void TestSummaryWithOneRectangle()
        {
            // Arrange
            var shapes = new List<Shape> { new Rectangle(5, 3) };

            // Act
            var summary = ShapeReportService.Generate(shapes, Language.Spanish);

            // Assert
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 15 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro 16 Area 15", summary);
        }

        [TestCase]
        public void TestSummaryWithOneTrapezoid()
        {
            // Arrange
            var shapes = new List<Shape> { new Trapezoid(8, 4, 5, 5, 3) };

            // Act
            var summary = ShapeReportService.Generate(shapes, Language.Spanish);

            // Assert
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapezoide | Area 18 | Perimetro 22 <br/>TOTAL:<br/>1 formas Perimetro 22 Area 18", summary);
        }
    }
}