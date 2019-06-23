using System;

namespace ZerosAtEndOfFactorial_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compute number of zeros at End of Factorial");

			Console.Write("Enter a number to compute factorial: ");
			long number = long.Parse(Console.ReadLine());

			double factorial = 1;
			for(int index = 1; index <= number; index++)
			{
				factorial *= index;
			}

			long multipleOfTen = 1;
			byte unitsPlace = 0;
			int numberOfZeros = 0;
			bool zeros = true;
			while(zeros)
			{
				unitsPlace = (byte)( (factorial / multipleOfTen) % 10 );

				if(unitsPlace == 0)
				{
					numberOfZeros++;
					multipleOfTen *= 10;
				}
				else
				{
					zeros = false;
				}
			}

			Console.WriteLine($"{number}! i.e. {factorial} has {numberOfZeros} number of zeros in the end.");
        }
    }
}
