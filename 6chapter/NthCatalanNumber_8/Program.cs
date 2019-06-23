using System;

namespace NthCatalanNumber_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Nth Catalan number i.e. (2N)! / ((N + 1)! * N!) where N >= 0");

			Console.Write("Enter N: ");
			double n = double.Parse(Console.ReadLine());

			double twoNFactorial = 1;
			double nFactorial = 1;
			double nPlusOneFactorial = 1;
			for(int index = 1; index <= 2 * n; index++)
			{
				twoNFactorial *= index;

				if(index == n)
				{
					nFactorial = twoNFactorial;
				}
				if(index == (n + 1))
				{
					nPlusOneFactorial = twoNFactorial;
				}
			}

			double nthCatalanNumber = twoNFactorial / (nPlusOneFactorial * nFactorial);

			Console.WriteLine($"Catalan number for N = {n} i.e. (2 * {n})! / (({n} + 1)! * {n}!) is: {nthCatalanNumber}.");
        }
    }
}
