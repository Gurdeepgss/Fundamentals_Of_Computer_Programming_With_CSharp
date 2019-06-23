using System;

namespace NaturalNumbers_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print first \"n\" Narutal numbers");

			Console.Write("Enter n: ");
			long n = long.Parse(Console.ReadLine());

			for(long index = 1; index <= n; index++)
			{
				if((index - 1) % 10 == 0)
				{
					Console.WriteLine();
				}
				Console.Write("\t" + index);
			}

			Console.WriteLine();
        }
    }
}
