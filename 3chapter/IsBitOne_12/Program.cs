using System;

namespace IsBitOne_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compute whether a bit at position p has value 1 or not");
			Console.WriteLine("Position starts from 0");
			Console.WriteLine();

			Console.Write("Enter the number: ");
			int number = int.Parse(Console.ReadLine());
			Console.Write("Enter the position: ");
			int position = int.Parse(Console.ReadLine());

			int tempNumber = number;
			tempNumber >>= position;
				
			if((tempNumber & 1) == 1)
				Console.WriteLine(true);
			else
				Console.WriteLine(false);
        }
    }
}
