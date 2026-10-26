using System;
using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Models
{
    public class EquilateralTriangle : Shape
    {
        private readonly decimal _length;

        public EquilateralTriangle(decimal length) : base(ShapeType.EquilateralTriangle)
        {
            _length = length;
        }
        public override decimal CalculateArea() => (decimal)(Math.Sqrt(3) / 4) * _length * _length;
        public override decimal CalculatePerimeter() => _length * 3;
    }
}
