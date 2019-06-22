using System;

namespace ProductOfThree_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Know the sign of product of three numbers");

			/* User Input three numbers */
			Console.Write("Enter number 1: ");
			double firstNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 2: ");
			double secondNumber = double.Parse(Console.ReadLine());
			Console.Write("Enter number 3: ");
			double thirdNumber = double.Parse(Console.ReadLine());

			/* Compute the sign witout performing multiplication */
			string sign = "";
			if(firstNumber < 0)
			{
				if(secondNumber < 0)
				{
					if(thirdNumber < 0)
					{
						sign = "negative";
					}
					else if(thirdNumber > 0)
					{
						sign = "positive";
					}
				}
				if(secondNumber > 0)
				{
					if(thirdNumber < 0)
					{
						sign = "positive";
					}
					else if(thirdNumber > 0)
					{
						sign = "negative";
					}
				}
			}
			else if(firstNumber > 0)
			{
				if(secondNumber < 0)
				{
					if(thirdNumber < 0)
					{
						sign = "positive";
					}
					else if(thirdNumber > 0)
					{
						sign = "negative";
					}
				}
				if(secondNumber > 0)
				{
					if(thirdNumber < 0)
					{
						sign = "negative";
					}
					else if(thirdNumber > 0)
					{
						sign = "positive";
					}
				}
			}

			Console.WriteLine($"The sign of multiplication of numbers {firstNumber} * {secondNumber} * {thirdNumber} is: {sign}");
        }
    }
}
