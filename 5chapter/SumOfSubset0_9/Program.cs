using System;

namespace SumOfSubset0_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Subsets with Sum 0 i.e. zero");

			Console.WriteLine("Enter five numbers to compute subsets with Sum zero");
			Console.Write("Enter number 1: ");
			double firstNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 2: ");
			double secondNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 3: ");
			double thirdNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 4: ");
			double fourthNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 5: ");
			double fifthNumber = double.Parse(Console.ReadLine());

			double sumOfAll = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
			string sumZero = "The subset with sum zero is:";
			bool sumZeroOnce = false;
			if(sumOfAll == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber}, {fifthNumber}.");
			}
			if((sumOfAll - firstNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {secondNumber}, {thirdNumber}, {fourthNumber}, {fifthNumber}.");
			}
			if((sumOfAll - secondNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {thirdNumber}, {fourthNumber}, {fifthNumber}.");
			}
			if((sumOfAll - thirdNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {secondNumber}, {fourthNumber}, {fifthNumber}.");
			}
			if((sumOfAll - fourthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {secondNumber}, {thirdNumber}, {fifthNumber}.");
			}
			if((sumOfAll - fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber}.");
			}
			if((sumOfAll - firstNumber - secondNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {thirdNumber}, {fourthNumber}, {fifthNumber}.");
			}
			if((sumOfAll - firstNumber - thirdNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {secondNumber}, {fourthNumber}, {fifthNumber}.");
			}
			if((sumOfAll - firstNumber - fourthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {secondNumber}, {thirdNumber}, {fifthNumber}.");
			}
			if((sumOfAll - firstNumber - fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {secondNumber}, {thirdNumber}, {fourthNumber}.");
			}
			if((sumOfAll - secondNumber - thirdNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {fourthNumber}, {fifthNumber}.");
			}
			if((sumOfAll - secondNumber - fourthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {thirdNumber}, {fifthNumber}.");
			}
			if((sumOfAll - secondNumber - fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {thirdNumber}, {fourthNumber}.");
			}
			if((sumOfAll - thirdNumber - fourthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {secondNumber}, {fifthNumber}.");
			}
			if((sumOfAll - thirdNumber - fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {secondNumber}, {fourthNumber}.");
			}
			if((sumOfAll - fourthNumber - fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {secondNumber}, {thirdNumber}.");
			}
			if((firstNumber + secondNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {secondNumber}.");
			}
			if((firstNumber + thirdNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {thirdNumber}.");
			}
			if((firstNumber + fourthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {fourthNumber}.");
			}
			if((firstNumber + fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}, {fifthNumber}.");
			}
			if((secondNumber + thirdNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {secondNumber}, {thirdNumber}.");
			}
			if((secondNumber + fourthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {secondNumber}, {fourthNumber}.");
			}
			if((secondNumber + fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {secondNumber}, {fifthNumber}.");
			}
			if((thirdNumber + fourthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {thirdNumber}, {fourthNumber}.");
			}
			if((thirdNumber + fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {thirdNumber}, {fifthNumber}.");
			}
			if((fourthNumber + fifthNumber) == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {fourthNumber}, {fifthNumber}.");
			}
			if(firstNumber == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {firstNumber}.");
			}
			if(secondNumber == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {secondNumber}.");
			}
			if(thirdNumber == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {thirdNumber}.");
			}
			if(fourthNumber == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {fourthNumber}.");
			}
			if(fifthNumber == 0)
			{
				sumZeroOnce = true;
				Console.WriteLine($"{sumZero} {fifthNumber}.");
			}
			if(sumZeroOnce == false)
			{
				Console.WriteLine("Ther is no subset with Sum 0 i.e. zero.");
			}
        }
    }
}
