using System;

namespace UseChoiceInput_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input as per Use choice");

			Console.WriteLine("1. Int");
			Console.WriteLine("2. Double");
			Console.WriteLine("3. String");
			Console.Write("Enter your choice(1-3): ");
			int choiceInput = int.Parse(Console.ReadLine());

			switch(choiceInput)
			{
				case 1:
					Console.Write("Enter an Integer: ");
					int intInput = int.Parse(Console.ReadLine());
					Console.WriteLine($"{intInput} is now {++intInput}.");
					break;
				case 2:
					Console.Write("Enter a Double: ");
					double doubleInput = double.Parse(Console.ReadLine());
					Console.WriteLine($"{doubleInput} is now {++doubleInput}.");
					break;
				case 3:
					Console.Write("Enter a string: ");
					string input = Console.ReadLine();
					string updatedInput = input + "*";
					Console.WriteLine($"{input} is now {updatedInput}.");
					break;
				default:
					Console.WriteLine($"{choiceInput} is not valid input.");
					break;
			}

        }
    }
}
