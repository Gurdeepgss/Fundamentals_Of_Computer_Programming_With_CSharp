using System;

namespace print_n_naturalNumbers_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prints sequence \"n\" natural numbers");
			Console.Write("Enter the last natural number of the sequence: ");
			long lastNaturalNumbers = long.Parse(Console.ReadLine());

			for(int index = 0; index < lastNaturalNumbers; index++)
			{
				Console.WriteLine($"{index + 1, 2}");
			}

        }
    }
}
