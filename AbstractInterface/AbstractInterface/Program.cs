using System.Drawing;

namespace AbstractInterface;

class Program
{
    static void Main(string[] args)
    {

        Rectangle rectangle = new Rectangle()
        {
            Height = 12,
            Width = 5
        };
        rectangle.CalculateArea();

        Circle circle = new Circle()
        {
            Radius = 12
        };
        circle.CalculateArea();

        Console.ReadLine();
    }
}
