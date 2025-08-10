using Solid.O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_principles.src.SOLID.O
{
    //    // BAD : This class violates the Open/Closed Principle by being tightly coupled to specific shape types.
    //public class Shape
    //{

    //    //public ShapeType Type { get; set; }
    //    //public double Radius { get; set; }
    //    //public double Length { get; set; }
    //    //public double Width { get; set; }

    //    //public double CalculateArea()
    //    //{
    //    //    return Type switch
    //    //    {
    //    //        ShapeType.Circle => Math.PI * Math.Pow(Radius, 2),
    //    //        ShapeType.Rectangle => Length * Width,
    //    //        _ => throw new NotSupportedException("Shape type not supported")
    //    //    };
    //    //}

    //}
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
}
