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

			/* using counter on number of negative numbers (Book's Implementation)*/
			int negativeNumberCount = 0;
			if(firstNumber < 0)
			{
				negativeNumberCount++;
			}
			if(secondNumber < 0)
			{
				negativeNumberCount++;
			}
			if(thirdNumber < 0)
			{
				negativeNumberCount++;
			}

			string sign = "";
			if(firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
			{
				Console.WriteLine($"Product of numbers {firstNumber}, {secondNumber}, {thirdNumber} is: 0.");
				Console.WriteLine("The Product holds no sign since it is 0 i.e. zero.");
			}
			else
			{
				if(negativeNumberCount % 2 == 0)
				{
					sign = "positive";
				}
				else
				{
					sign = "negative";
				}
				Console.WriteLine($"The sign of multiplication of numbers {firstNumber} * {secondNumber} * {thirdNumber} is: {sign}");
			}


			/* My implementation */
//			/* Compute the sign witout performing multiplication */
//			string sign = "";
//			if(firstNumber < 0)
//			{
//				if(secondNumber < 0)
//				{
//					if(thirdNumber < 0)
//					{
//						sign = "negative";
//					}
//					else if(thirdNumber > 0)
//					{
//						sign = "positive";
//					}
//				}
//				if(secondNumber > 0)
//				{
//					if(thirdNumber < 0)
//					{
//						sign = "positive";
//					}
//					else if(thirdNumber > 0)
//					{
//						sign = "negative";
//					}
//				}
//			}
//			else if(firstNumber > 0)
//			{
//				if(secondNumber < 0)
//				{
//					if(thirdNumber < 0)
//					{
//						sign = "positive";
//					}
//					else if(thirdNumber > 0)
//					{
//						sign = "negative";
//					}
//				}
//				if(secondNumber > 0)
//				{
//					if(thirdNumber < 0)
//					{
//						sign = "negative";
//					}
//					else if(thirdNumber > 0)
//					{
//						sign = "positive";
//					}
//				}
//			}
        }
    }
}
