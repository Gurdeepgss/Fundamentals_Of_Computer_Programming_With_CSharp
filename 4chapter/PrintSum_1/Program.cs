using System;

namespace PrintSum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the Sum");

			Console.Write("Enter first number: ");
			float firstNumber = float.Parse(Console.ReadLine());

			Console.Write("Enter second number: ");
			float secondNumber = float.Parse(Console.ReadLine());

			/*
			 * Conversion of String to a Number type
			 *
			 * float thirdNumber = (float)(Console.ReadLine()); 
			 * (typeof) conversions does not work for string conversion to int, float or double
			 * types.
			 *
			 * float thirdNumber = Convert.ToFloat(Console.ReadLine()); 
			 * this mehtod does not exist. while other methods like Convert.ToDouble() and
			 * Convert.ToInt32() does work.
			 *
			 * all the type.Parse() methods do work, like int.Parse(), float.Parse(),
			 * double.Parse().
			 */
			Console.Write("Enter third number: ");
			double thirdNumber = float.Parse(Console.ReadLine());

			double sumOf3 = firstNumber + secondNumber + thirdNumber;
			Console.WriteLine($"Sum of {firstNumber} + {secondNumber} + {thirdNumber} is {sumOf3}.");
			Console.WriteLine($"Or Simply {firstNumber} + {secondNumber} + {thirdNumber} = {sumOf3}");
        }
    }
}
