using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Models
{
    public class Rectangle : Shape
    {
        private readonly decimal _length;
        private readonly decimal _width;

        public Rectangle(decimal length, decimal width) : base(ShapeType.Rectangle)
        {
            _length = length;
            _width = width;
        }
        public override decimal CalculateArea() => _length * _width;
        public override decimal CalculatePerimeter() => 2 * (_length + _width);
    }
}