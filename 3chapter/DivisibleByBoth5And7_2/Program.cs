using System;

namespace DivisibleByBoth5And7_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number to check it's divisibility by both 5 and 7: ");
			int userInput = int.Parse(Console.ReadLine());

			int five = 5;
			int seven = 7;
			/*
			 * LCM_GCD.LCM(); function is used from LCM_GCD class in DivisibleByBoth5And7_2
			 * namespace
			 */
			int? lcmOf5And7 = LCM_GCD.LCM(five, seven);

			bool divisible = (userInput % lcmOf5And7 == 0)? true : false;

			Console.Write($"{userInput} is ");
			if(!divisible)
				Console.Write("not");
			Console.Write($" divisible by both {five} and {seven}");

			Console.WriteLine();
		}
	}
}
