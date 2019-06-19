using System;

namespace PerimeterAndAreaOfCircle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Perimeter and Area of Circle");

			Console.Write("Enter 1 for Area or 2 for Perimeter of Circle: ");
			int choice = int.Parse(Console.ReadLine());

			if(choice == 1 || choice == 2)
			{
				Console.Write("Enter radius of Circle: ");
				float radius = float.Parse(Console.ReadLine());

				string measure;
				float result;

				if(choice == 1)
				{
					measure = "Area";
					result = (float)(Math.PI * Math.Pow(radius, 2));
				}
				else
				{
					measure = "Perimeter";
					result = (float)(2 * Math.PI * radius);
				}

				Console.WriteLine($"The {measure} of Circle with radius {radius} is {result:F2}.");
			}
			else
			{
				Console.WriteLine($"Choice {choice} is not valid.");
			}
        }
    }
}
