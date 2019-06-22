using System;

namespace RootsOfQuadratic_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print roots of Quadratic equation");

			char uppercaseTwo = '\u00b2';
			Console.WriteLine($"Enter coefficients of Quadratic equation of ax{uppercaseTwo} + bx + c = 0");
			Console.Write("Enter a: ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("Enter b: ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Enter c: ");
			double c = double.Parse(Console.ReadLine());

			double discriminant = Math.Pow(b, 2) - 4 * a * c;
			bool realRoots = ((Math.Pow(b, 2) - 4 * a * c) >= 0)? true : false;

			if(realRoots)
			{
				if(discriminant > 0)
				{
					double root1 = ( (-1 * b) + Math.Pow(discriminant, 0.5) ) / (2 * a);
					double root2 = ( (-1 * b) - Math.Pow(discriminant, 0.5) ) / (2 * a);

					Console.WriteLine($"Roots of equation {a}x{uppercaseTwo} + {b}x + {c} = 0 are: {root1} and {root2}.");
				}
				else if(discriminant == 0)
				{
					double root = (-1 * b) / (2 * a);
					Console.WriteLine($"Roots of equation {a}x{uppercaseTwo} + {b}x + {c} = 0 are: {root} and {root}.");
				}
			}
			else
			{
				Console.WriteLine($"The equation {a}x{uppercaseTwo} + {b}x + {c} = 0 has no real roots.");
			}
        }
    }
}
