using System;
using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Models
{
    public class Circle : Shape
    {
        private readonly decimal _diameter;

        public Circle(decimal diameter) : base(ShapeType.Circle)
        {
            _diameter = diameter;
        }
        public override decimal CalculateArea() => (decimal)Math.PI * (_diameter / 2) * (_diameter / 2);
        public override decimal CalculatePerimeter() => (decimal)Math.PI * _diameter;
    }
}
