using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Models
{
    public class Square : Shape
    {
        private readonly decimal _length;

        public Square(decimal length) : base(ShapeType.Square)
        {
            _length = length;
        }
        public override decimal CalculateArea() => _length * _length;
        public override decimal CalculatePerimeter() => _length * 4;
    }
}