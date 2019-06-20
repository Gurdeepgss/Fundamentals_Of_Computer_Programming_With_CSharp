using System;

namespace SumOfNumbers_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number \"n\" to compute sum of \"n\" numbers: ");
			int numberOfTerms = int.Parse(Console.ReadLine());

			double sum = 0;
			for(int index = 0; index < numberOfTerms; index++)
			{
				Console.Write($"{index + 1,3}. ");
				sum += double.Parse(Console.ReadLine());
			}

			Console.WriteLine($"Sum of the numbers entered is: {sum}.");
        }
    }
}
