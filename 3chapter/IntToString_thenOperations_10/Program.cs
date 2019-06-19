using System;

namespace IntToString_thenOperations_10
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
			 * Book's Implementation
			 */
			Console.Write("Enter a four-digit number: ");
			int number = int.Parse(Console.ReadLine());

			/* Get individual digits of the four digit number */
			int num0 = number % 10;
			int num1 = (number / 10) % 10;
			int num2 = (number / 100) % 10;
			int num3 = (number / 1000) % 10;

			string strNumber0 = num0.ToString();
			string strNumber1 = num1.ToString();
			string strNumber2 = num2.ToString();
			string strNumber3 = num3.ToString();

			int sumOfDigits = num0 + num1 + num2 + num3;
			string reversedDigits = strNumber0 + strNumber1 + strNumber2 + strNumber3 ;
			string lastInFirstPosition = strNumber0 + strNumber2 + strNumber1 + strNumber3;
			string secondSwapThird = strNumber3 + strNumber1 + strNumber2 + strNumber0;

			Console.WriteLine($"Sum of digits of {number} is {sumOfDigits}.");
			Console.WriteLine($"Reversed number is {reversedDigits}");
			Console.WriteLine($"Last digit put in first position {lastInFirstPosition}");
			Console.WriteLine($"Second and third number swapped {secondSwapThird}");

//			//short intNumber = 0;
//			
//			int triesLeft = 3;
//			while(triesLeft != 0)
//			{
//				Console.WriteLine($"\n{triesLeft--} tries left");
//				Console.Write("Enter a four-digit number: ");
//				string number = Console.ReadLine();
//
//				if(number.Length <= 4)
//				{
//					/*
//  					 *	try
// 					 *	{
// 					 *		intNumber = short.Parse(number);
// 					 *	}
// 					 *	catch(Exception ex)
// 					 *	{
// 					 *		Console.WriteLine(ex);
// 					 *	}
// 					 *	
//					 *	number = intNumber.ToString();
//					 */
//
//					/*
//					 * int.Parse seems to work only for string argument i.e. why every
//					 * character of the string number is converted into string type.
//					 * The (int) cast in case of (int)(charVariable) returns the ASCII value of
//					 * the character charVariable and does not return the int in the char
//					 * resulting into wrong sumOfDigits.
//					 *
//					 * In all other cases string concatenation is used
//					 */
//					string strNumber3 = number[3].ToString();
//					string strNumber2 = number[2].ToString();
//					string strNumber1 = number[1].ToString();
//					string strNumber0 = number[0].ToString();
//
//					int sumOfDigits = int.Parse(strNumber0) + int.Parse(strNumber1) + int.Parse(strNumber2) + int.Parse(strNumber3);
//					string reversedDigits = strNumber3 + strNumber2 + strNumber1 + strNumber0;
//					string lastInFirstPosition = strNumber3 + strNumber1 + strNumber2 + strNumber0;
//					string secondSwapThird = strNumber0 + strNumber2 + strNumber1 + strNumber3;
//
//					Console.WriteLine($"Sum of digits of {number} is {sumOfDigits}.");
//					Console.WriteLine($"Reversed number is {reversedDigits}");
//					Console.WriteLine($"Last digit put in first position {lastInFirstPosition}");
//					Console.WriteLine($"Second and third number swapped {secondSwapThird}");
//
//					break;
//				}
//			}

        }
    }
}
