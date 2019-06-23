using System;

namespace FactorialDivision_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compute n!/k! (where 1<k<n)");

			Console.Write("Enter n: ");
			long n = long.Parse(Console.ReadLine());
			Console.Write("Enter k: ");
			long k = long.Parse(Console.ReadLine());

			double kFactorial = 1;
			double nFactorial = 1;
			double nMinus
			for(int index = 1; index <= n; index++)
			{
				nFactorial *= index;

				if(index == k)
				{
					kFactorial = nFactorial;
				}
			}

			Console.WriteLine($"{n}! = {nFactorial}, {k}! = {kFactorial}.");

			double factorialDivision = nFactorial / kFactorial;

			Console.WriteLine($"{n}! / {k}! is: {factorialDivision}.");
        }
    }
}
