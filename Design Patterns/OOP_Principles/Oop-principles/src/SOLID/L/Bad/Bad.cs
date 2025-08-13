using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_principles.src.SOLID.L.Bad
{

    // Bad example of Liskov Substitution Principle (LSP) violation
    //class Bird
    //{
    //    public virtual void Fly()
    //    {
    //        Console.WriteLine("The bird is flying.");
    //    }
    //}

    //class Penguin : Bird
    //{
    //    public override void Fly()
    //    {
    //        // Penguins can't fly — but this still exists because of inheritance
    //        throw new NotSupportedException("Penguins can't fly!");
    //    }
    //}

    class Bird
    {
    }
    class FlightlessBird:Bird
    {
        
    }
    class FlightBird : Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }
    class Penguin : FlightlessBird
    {
       
    }

}
