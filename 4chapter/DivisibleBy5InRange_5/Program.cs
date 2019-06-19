using System;

namespace DivisibleBy5InRange_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers in Range (a, b) divisible by 5");

			Console.Write("Enter lower bound of the range: ");
			int lowerBound = int.Parse(Console.ReadLine());

			Console.Write("Enter upper bound of the range: ");
			int upperBound = int.Parse(Console.ReadLine());

			string divisibleBy5 = "";
			int counter = 0;
			for(int index = lowerBound; index <= upperBound; index++)
			{
				if(index % 5 == 0)
				{
					counter++;
					divisibleBy5 = divisibleBy5 + " " + index;
				}
			}

			Console.WriteLine($"There are {counter} numbers divisible by 5 in range ({lowerBound}, {upperBound}).");
			Console.WriteLine($"The numbers are {divisibleBy5}.");
        }
    }
}
