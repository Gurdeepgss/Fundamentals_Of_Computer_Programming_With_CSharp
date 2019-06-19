using System;

namespace RealNumberAccuracyAtLeast6_3
{
    class Program
    {
        static void Main(string[] args)
        {
			/* 
			 * high precision(in this case numbers with atleast 6 digits after decimal point)
			 * numbers compared 
			 */
			float firstNumber = 0.83720677F;
			float secondNumber = 0.83720678F;

			/*
			 * The Book's implementation
			 */
			bool equal = Math.Abs(firstNumber-secondNumber) < 0.000001;
			Console.WriteLine("This is written in Book: Two floating-point numbers are considered equal if their difference is less than some predefined precision(e.g.: 0.000001)");

			Console.WriteLine("\tMust See the source code of this program");

			Console.WriteLine($"float firstNumber = {firstNumber}F");
			Console.WriteLine($"float secondNumber = {secondNumber}F");
			Console.WriteLine($"bool equal = Math.Abs(firstNumber-secondNumber) < 0.000001;");
			Console.WriteLine($"equal = {equal}.");

		    /* 
			 * This was My implementation of my understanding of the question
			 *	if(firstNumber > secondNumber)
			 *		Console.WriteLine($"\t{firstNumber} is bigger than {secondNumber}.");
			 *	else if(firstNumber < secondNumber)
			 *		Console.WriteLine($"\t{secondNumber} is bigger than {firstNumber}.");
			 *	else
			 *		Console.WriteLine($"\t{firstNumber} and {secondNumber} both are equal.");
			 */
        }
    }
}
