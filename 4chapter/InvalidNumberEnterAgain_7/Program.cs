using System;

namespace InvalidNumberEnterAgain_7
{
    class Program
    {
        static void Main(string[] args)
        {
			int firstNumber = 0;
			int secondNumber = 0;
			int thirdNumber = 0;
			int fourthNumber = 0;
			int fifthNumber = 0;
			bool rightInput = false;

            Console.WriteLine("Sum of Five integers");

			/*
			 * There should be a function for DRY to be implemented here
			 */
			while(!rightInput)
			{
				Console.Write("Enter number 1: ");
				rightInput = int.TryParse(Console.ReadLine(), out firstNumber);

				string again = "\nInvalid Input, try again\n";
				Console.Write(rightInput? "" : again);
			}

			rightInput = false;
			while(!rightInput)
			{
				Console.Write("Enter number 2: ");
				rightInput = int.TryParse(Console.ReadLine(), out secondNumber);

				string again = "\nInvalid Input, try again\n";
				Console.Write(rightInput? "" : again);
			}

			rightInput = false;
			while(!rightInput)
			{
				Console.Write("Enter number 3: ");
				rightInput = int.TryParse(Console.ReadLine(), out thirdNumber);

				string again = "\nInvalid Input, try again\n";
				Console.Write(rightInput? "" : again);
			}

			rightInput = false;
			while(!rightInput)
			{
				Console.Write("Enter number 4: ");
				rightInput = int.TryParse(Console.ReadLine(), out fourthNumber);

				string again = "\nInvalid Input, try again\n";
				Console.Write(rightInput? "" : again);
			}

			rightInput = false;
			while(!rightInput)
			{
				Console.Write("Enter number 5: ");
				rightInput = int.TryParse(Console.ReadLine(), out fifthNumber);

				string again = "\nInvalid Input, try again\n";
				Console.Write(rightInput? "" : again);
			}

			long sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
			Console.WriteLine($"{firstNumber} + {secondNumber} + {thirdNumber} + {fourthNumber} + {fifthNumber} = {sum};");
        }
    }
}
