using System;

namespace FibonacciSequenceFirst100_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 100 numbers in Fibonacci sequence: ");

			double present = 1;
			double previous = 0;
			double sum = 0;

			Console.WriteLine($"{previous,2}\n{present,2}");

			for(int index = 0; index < 100; index++)
			{
				sum = present + previous;
				previous = present;
				present = sum;

				Console.WriteLine($"{index + 1,3}. {sum, 2}");
			}
        }
    }
}
