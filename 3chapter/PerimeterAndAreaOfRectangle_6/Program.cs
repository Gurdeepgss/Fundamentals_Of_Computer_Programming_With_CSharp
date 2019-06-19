using System;

namespace PerimeterOfRectangle_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tPerimeter and Area of Rectangle");

			Console.Write("Enter bottom-length of Rectangle: ");
			double bottomLength = double.Parse(Console.ReadLine());

			Console.Write("Enter height of Rectangle: ");
			double height = double.Parse(Console.ReadLine());

			Console.WriteLine($"Perimeter of Rectangle is {2 * (bottomLength + height)}.");
			Console.WriteLine($"Area of Rectangle is {bottomLength * height}.");
        }
    }
}
