using System;

namespace AreaOfTrapezoid_5
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("\tArea of Trapezoid");
			Console.Write("Enter top-length of Trapezoid: ");
			double topLength = double.Parse(Console.ReadLine());

			Console.Write("Enter bottom-length of Trapezoid: ");
			double bottomLength = double.Parse(Console.ReadLine());

            Console.Write("Enter height of Trapezoid: ");
			double height = double.Parse(Console.ReadLine());

			double AreaOfTrapezoid = (topLength + bottomLength) * height / 2;

			Console.WriteLine($"Area Of Trapezoid with top-length: {topLength}, bottom-length: {bottomLength} and height: {height} is {AreaOfTrapezoid}.");
        }
    }
}
