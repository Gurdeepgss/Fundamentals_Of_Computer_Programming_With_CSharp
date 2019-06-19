using System;

namespace IsItInsideCircle_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Circle has radius of 5 units and it's center is at origin");
			Console.WriteLine("Does your point lie inside the circle or not?");

			Console.WriteLine("Enter the co-ordinates of the point to check");
			Console.Write("X co-ordinate: ");
			double xCoordinate = double.Parse(Console.ReadLine());
			Console.Write("Y co-ordinate: ");
			double yCoordinate = double.Parse(Console.ReadLine());

			bool isItInsideCircle = Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2) < Math.Pow(5, 2);

			if(isItInsideCircle)
				Console.WriteLine($"Point {xCoordinate},{yCoordinate} is inside this Circle.");
			else
				Console.WriteLine($"Point {xCoordinate},{yCoordinate} is either on or outside this Circle.");
        }
    }
}
