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

			double kfactorial = 1;
			double nfactorial = 1;
			for(int index = 1; index <= n; index++)
			{
				nfactorial *= index;

				if(index == k)
				{
					kfactorial = nfactorial;
				}
			}

			Console.WriteLine($"{n}! = {nfactorial}, {k}! = {kfactorial}.");

			double factorialDivision = nfactorial / kfactorial;

			Console.WriteLine($"{n}! / {k}! is: {factorialDivision}.");
        }
    }
}
