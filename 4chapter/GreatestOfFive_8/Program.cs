using System;

namespace GreatestOfFive_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greatest of the Five Numbers");

			Console.Write("Enter first number:");
			double firstNumber = double.Parse(Console.ReadLine());

			Console.Write("Enter second number:");
			double secondNumber = double.Parse(Console.ReadLine());

			Console.Write("Enter third number:");
			double thirdNumber = double.Parse(Console.ReadLine());

			Console.Write("Enter fourth number:");
			double fourthNumber = double.Parse(Console.ReadLine());

			Console.Write("Enter fifth number:");
			double fifthNumber = double.Parse(Console.ReadLine());

			string all = $"{firstNumber} {secondNumber} {thirdNumber} {fourthNumber} {fifthNumber}";

			for(int index = 0; index < 2; index++)
			{
				firstNumber = (firstNumber > secondNumber)? firstNumber : secondNumber;
				if(index == 1)
				{
					fourthNumber = firstNumber;
					fifthNumber = thirdNumber;
				}
				secondNumber = (fourthNumber > fifthNumber)? fourthNumber : fifthNumber;
			}

			Console.WriteLine($"Greatest among {all} is {secondNumber}.");
        }
    }
}
