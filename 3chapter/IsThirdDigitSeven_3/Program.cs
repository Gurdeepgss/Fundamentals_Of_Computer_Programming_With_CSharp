using System;

namespace IsThirdDigitSeven_3
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
			 * For the implementation in book check program IntToString_thenOperations_10
			 * lines of code 16 through 19
			 */

			Console.Write("Enter a number: ");
			string userInput = Console.ReadLine();

			char charInHunderedsPlace = userInput[userInput.Length-3];
			bool contains7 = string.Equals(charInHunderedsPlace, '7');

			if(contains7)
				Console.WriteLine($"{userInput} contains 7 in hundered's place.");
			else
				Console.WriteLine($"{userInput} does not contain 7 in hundered's place.");
        }
    }
}
