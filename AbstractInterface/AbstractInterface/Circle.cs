using System;
using AbstractInterface;

namespace AbstractInterface
{
    public class Circle : Shape, IShape
    {
        public double Radius;

        public void CalculateArea()
        {
            Console.WriteLine("Dairenin sahesi: " + 3.14 * (Radius * Radius));
        }

        //public override void CalculateArea()
        //{
        //    Console.WriteLine("Dairenin sahesi: "+3.14*(Radius*Radius));
        //}



    }
}

