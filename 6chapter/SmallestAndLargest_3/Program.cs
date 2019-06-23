using System;

namespace SmallestAndLargest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compute Smallest and Largest number among input");

			double largest = double.MinValue;
			double smallest = double.MaxValue;
			while(true)
			{
				Console.Write("Enter a number or q to quit: ");
				string userInput = Console.ReadLine();

				if(userInput == "q")
				{
					break;
				}

				double userNumber = double.Parse(userInput);

				if(userNumber > largest)
				{
					largest = userNumber;
				}
				if(userNumber < smallest)
				{
					smallest = userNumber;
				}
			}

			Console.WriteLine($"The Smallest number is: {smallest}.");
			Console.WriteLine($"The Largest number is: {largest}.");
        }
    }
}
