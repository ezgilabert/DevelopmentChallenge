using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Models
{
    public abstract class Shape
    {
        public ShapeType ShapeType { get; }

        public abstract decimal CalculateArea();
        public abstract decimal CalculatePerimeter();

        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }
    }
}