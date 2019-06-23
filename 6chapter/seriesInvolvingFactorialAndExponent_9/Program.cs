using System;

namespace seriesInvolvingFactorialAndExponent_9
{
    class Program
    {
        static void Main(string[] args)
        {
			string specialSeries = " 0!/x\u2070 + 1!/x\u00b9 + 2!/x\u00b2 + 3!/x\u00b3 + ... + n!/x\u207f";
            Console.WriteLine($"Sum of Special series {specialSeries}");

			Console.Write("Enter x: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("Enter n: ");
			int n = int.Parse(Console.ReadLine());

			double sumOfSpecialSeries = 1;
			double factorial = 1;
			double exponentialTerm = 0;
			specialSeries = "1/1";
			for(int index = 1; index <= n; index++)
			{
				factorial *= index;
				exponentialTerm = Math.Pow(x, index);
				specialSeries += $" + {factorial}/{exponentialTerm}";
				sumOfSpecialSeries += factorial / exponentialTerm;
			}

			Console.WriteLine($"{specialSeries} = {sumOfSpecialSeries}.");
        }
    }
}
