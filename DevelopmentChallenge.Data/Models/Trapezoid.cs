using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Models
{
    public class Trapezoid : Shape
    {
        private readonly decimal _base1;
        private readonly decimal _base2;
        private readonly decimal _side1;
        private readonly decimal _side2;
        private readonly decimal _height;

        public Trapezoid(decimal base1, decimal base2, decimal side1, decimal side2, decimal height) : base(ShapeType.Trapezoid)
        {
            _base1 = base1;
            _base2 = base2;
            _side1 = side1;
            _side2 = side2;
            _height = height;
        }
        public override decimal CalculateArea() => (_base1 + _base2) * _height / 2;
        public override decimal CalculatePerimeter() => _base1 + _base2 + _side1 + _side2;
    }
}