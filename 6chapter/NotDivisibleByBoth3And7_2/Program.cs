using System;

namespace NotDivisibleByBoth3And7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers in range 1 to N, not divisible both by 3 and 7 simultaneously");

			Console.Write("Enter N: ");
			long n = long.Parse(Console.ReadLine());

			for(long index = 1, counter = 0; index <= n; index++, counter++)
			{
				/*
				 * Prints newline after 10 numbers in line
				 * (index % 21 != 0) prevents output of double newline when index is multiple
				 * of 21 and counter in multiple of 10, because without (index % 21 != 0) a
				 * newline will be printed after counter is 20 and counter is reduced by one due
				 * to counter-- when index is 21 and with updation statement conter again
				 * becomes 20 which leads to printing of one more newline, and counter is not
				 * reduced by one this time as value of index is not multiple of 21
	 			 */
				if(counter % 10 == 0 && index % 21 != 0)
				{
					Console.WriteLine();
				}

				if((index % 21) == 0)
				{
					counter--;
					continue;
				}
				Console.Write("\t" + index);
			}

			Console.WriteLine();
        }
    }
}
