using System;
namespace AbstractInterface
{
    public class Rectangle : Shape, IShape
    {
        public double Height;
        public double Width;

        public void CalculateArea()
        {
            Console.WriteLine("duzbucaqlinin sahesi: " + Height * Width);

        }

        //public override void CalculateArea()
        //{
        //    Console.WriteLine("duzbucaqlinin sahesi: "+Height*Width);
        //}
    }
}

