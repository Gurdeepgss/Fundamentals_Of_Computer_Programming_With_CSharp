using System;

namespace PrintGreaterWithTwist_6
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
			 * This program is to be done without using conditional statements
			 */
            Console.WriteLine("Find which number is greater");

			Console.Write("Enter first number: ");
			double firstNubmer = double.Parse(Console.ReadLine());
			Console.Write("Enter second number: ");
			double secondNumber = double.Parse(Console.ReadLine());

			double greater = (firstNubmer > secondNumber)? firstNubmer : secondNumber;
			double lesser = (firstNubmer + secondNumber) - greater;

			Console.WriteLine($"{greater} is greater than {lesser}.");
        }
    }
}
