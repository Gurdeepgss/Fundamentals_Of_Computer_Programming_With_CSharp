using System;

namespace NumberOutputFormatted_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print three numbers in a format");

			/* Get the Input */
			Console.Write("Enter number 1: ");
			int oneNumber = int.Parse(Console.ReadLine());
			Console.Write("Enter number 2: ");
			double twoNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 3: ");
			double threeNumber = double.Parse(Console.ReadLine());

			/* Print formatted Output */
			Console.WriteLine();
			/* hecadecimal format only works for number of Integer type like byte, short, int*/
			Console.Write($"{oneNumber,-10:X}");
			Console.Write($"{twoNumber,-10:F}");
			Console.Write($"{threeNumber,-10:F}");
			Console.WriteLine();
			Console.WriteLine();
        }
    }
}
