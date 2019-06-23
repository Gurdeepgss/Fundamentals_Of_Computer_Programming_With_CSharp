using System;

namespace FirstNFibonacciNumbers_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First \"n\" Fibonacci numbers");

			Console.Write("Enter n: ");
			long n = long.Parse(Console.ReadLine());

			double zero = 0;
			double one = 1;
			double nextNumber = 0;
			for(int index = 0; index < n; index++)
			{
				if(index == 0)
				{
					Console.Write($"{zero, 25}{one, 25}");
					index = 2;
				}

				nextNumber = one + zero;
				zero = one;
				one = nextNumber;

				Console.Write($"{nextNumber, 25}");

				if((index + 1) % 4 == 0)
				{
					Console.WriteLine();
				}
			}

			Console.WriteLine();
        }
    }
}
