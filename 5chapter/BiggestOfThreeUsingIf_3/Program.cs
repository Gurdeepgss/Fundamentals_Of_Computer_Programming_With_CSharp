using System;

namespace BiggestOfThreeUsingIf_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the Biggest among three numbers");

			/* User Input the numbers */
			Console.Write("Enter number 1: ");
			double firstNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 2: ");
			double secondNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 3: ");
			double thirdNumber = double.Parse(Console.ReadLine());

			/* Compute the biggest using if statements */
			double biggest = double.MinValue;
			if(firstNumber > secondNumber)
			{
				if(firstNumber > thirdNumber)
				{
					biggest = firstNumber;
				}
				else
				{
					biggest = thirdNumber;
				}
			}
			else
			{
				if(secondNumber > thirdNumber)
				{
					biggest = secondNumber;
				}
				else
				{
					biggest = thirdNumber;
				}
			}

			/* Print out the result */
			Console.WriteLine($"The Biggest number among {firstNumber}, {secondNumber}, {thirdNumber} is: {biggest}");
        }
    }
}
