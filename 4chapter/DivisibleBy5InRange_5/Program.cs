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
			int index = lowerBound;
			int counter = 0;

			/* One of the implementations from Book */
			while(true)
			{
				if(index % 5 == 0)
					break;
				index++;
			}
			
			/*
			 * using the fact that if a number is divisible by 5 then every 5th number from it
			 * is also divisible by 5 
			 */
			while(index <= upperBound)
			{
				counter++;
				divisibleBy5 = divisibleBy5 + " " + index;
				index += 5;
			}
			/*
			 * My implementation
			 *	for(int index = lowerBound; index <= upperBound; index++)
			 *	{
			 *		if(index % 5 == 0)
			 *		{
			 *			counter++;
			 *			divisibleBy5 = divisibleBy5 + " " + index;
			 *		}
			 *	}
			 */
			Console.WriteLine($"There are {counter} numbers divisible by 5 in range ({lowerBound}, {upperBound}).");
			Console.WriteLine($"The numbers are {divisibleBy5}.");
        }
    }
}
