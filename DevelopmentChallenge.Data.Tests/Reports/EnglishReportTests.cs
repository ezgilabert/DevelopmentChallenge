using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Reports;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class EnglishReportTests
    {
        [TestCase]
        public void TestEmptyListSummary()
        {
            // Arrange
            var language = Language.English;

            // Assert
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ShapeReportService.Generate(new List<Shape>(), language));
        }

        [TestCase]
        public void TestSummaryWithMultipleSquares()
        {
            // Arrange
            var shapes = new List<Shape> { new Square(5), new Square(1), new Square(3) };

            // Act
            var summary = ShapeReportService.Generate(shapes, Language.English);

            // Assert
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", summary);
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
            var summary = ShapeReportService.Generate(shapes, Language.English);

            // Assert
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                summary);
        }

        [TestCase]
        public void TestSummaryWithMultipleRectangles()
        {
            // Arrange
            var shapes = new List<Shape> { new Rectangle(5, 3), new Rectangle(2, 4) };

            // Act
            var summary = ShapeReportService.Generate(shapes, Language.English);

            // Assert
            Assert.AreEqual("<h1>Shapes report</h1>2 Rectangles | Area 23 | Perimeter 28 <br/>TOTAL:<br/>2 shapes Perimeter 28 Area 23", summary);
        }

        [TestCase]
        public void TestSummaryWithMultipleTrapezoids()
        {
            // Arrange
            var shapes = new List<Shape> { new Trapezoid(8, 4, 5, 5, 3), new Trapezoid(6, 2, 4, 4, 2) };

            // Act
            var summary = ShapeReportService.Generate(shapes, Language.English);

            // Assert
            Assert.AreEqual("<h1>Shapes report</h1>2 Trapezoids | Area 26 | Perimeter 38 <br/>TOTAL:<br/>2 shapes Perimeter 38 Area 26", summary);
        }
    }
}