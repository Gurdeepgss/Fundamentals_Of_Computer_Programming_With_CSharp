using System;

namespace SortingUsingIf_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort three numbers");

			/* User Input the numbers */
			Console.Write("Enter number 1: ");
			double firstNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 2: ");
			double secondNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 3: ");
			double thirdNumber = double.Parse(Console.ReadLine());

			/* Compute the biggest using if statements */
			double biggest = double.MinValue;
			double middle = double.MinValue;
			double smallest = double.MaxValue;
			if(firstNumber > secondNumber)
			{
				if(firstNumber > thirdNumber)
				{
					biggest = firstNumber;
					middle = (secondNumber > thirdNumber)? secondNumber : thirdNumber;
					smallest = (secondNumber + thirdNumber) - middle;
				}
				else
				{
					biggest = thirdNumber;
					middle = firstNumber;
					smallest = secondNumber;
				}
			}
			else
			{
				if(secondNumber > thirdNumber)
				{
					biggest = secondNumber;
					middle = (firstNumber > thirdNumber)? secondNumber : thirdNumber;
					smallest = (firstNumber + thirdNumber) - middle;
				}
				else
				{
					biggest = thirdNumber;
					middle = secondNumber;
					smallest = firstNumber;
				}
			}

			/* Print out the result */
			Console.WriteLine($"Numbers {firstNumber}, {secondNumber}, {thirdNumber} in Descending order are: {biggest}, {middle}, {smallest}");
        }
    }
}
