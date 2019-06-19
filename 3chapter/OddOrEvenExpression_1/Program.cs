using System;

namespace OddOrEvenExpression_1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter a number to check for even or odd: ");
			int userInput = int.Parse(Console.ReadLine());

			bool isEven = (userInput % 2 == 0)? true : false;

			Console.WriteLine($"The statement: {userInput} is Even, is {isEven}");
        }
    }
}
