using System;

namespace ExchangeValueIfFirstGreater_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to exchange values of first number is greater");

			Console.Write("Enter first number: ");
			double firstNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter second number: ");
			double secondNumber = double.Parse(Console.ReadLine());

			Console.WriteLine($"first number is: {firstNumber}.");
			Console.WriteLine($"second number is: {secondNumber}.");

			if(firstNumber > secondNumber)
			{
				double temp = secondNumber;
				secondNumber = firstNumber;
				firstNumber = temp;
				Console.WriteLine("\nThe excahanged Values are listed below");
				Console.WriteLine($"first number is: {firstNumber}.");
				Console.WriteLine($"second number is: {secondNumber}.");
			}

        }
    }
}
