using System;

namespace InsideCircleOutsideRectangle_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Circle has radius of 5 units and it's center is at origin");
			Console.WriteLine("The co-ordinates of Rectangle are {-1, 1}, {5, 5}");
			Console.WriteLine("Does your point lie inside the circle and outside the Rectangle?");

			Console.WriteLine("Enter the co-ordinates of the point to check");
			Console.Write("X co-ordinate: ");
			double xCoordinate = double.Parse(Console.ReadLine());
			Console.Write("Y co-ordinate: ");
			double yCoordinate = double.Parse(Console.ReadLine());

			bool insideCircle = Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2) < Math.Pow(5, 2);

			bool insideHorizontalRange = (xCoordinate > -1) && (xCoordinate < 5);
			bool insideVerticalRange = (yCoordinate > 1) && (yCoordinate < 5);
			bool outsideRectangle = !(insideHorizontalRange && insideVerticalRange);

			if(insideCircle)
			{
				Console.Write($"Point {xCoordinate},{yCoordinate} is inside the Circle");
				if(outsideRectangle)
					Console.Write(" and outside the Rectangle.");
				else
					Console.Write(" and also inside the Rectangle.");
			}
			else
				Console.Write($"Point {xCoordinate},{yCoordinate} is either on or outside the Circle and definitely outside the Rectangle.");

			Console.WriteLine();
        }
    }
}
