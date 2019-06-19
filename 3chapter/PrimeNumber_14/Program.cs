using System;

namespace PrimeNumber_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check whether a number is prime or not");
			Console.Write("Enter a number (1-100): ");
			int isPrime = int.Parse(Console.ReadLine());

			bool notPrime = false;
			for(int index = 2; index < isPrime; index++)
			{
				if(isPrime % index == 0)
				{
					notPrime = true;
					break;
				}
			}

			if(notPrime)
			{
				Console.WriteLine($"{isPrime} is not prime.");
			}
			else
			{
				Console.WriteLine($"{isPrime} is prime.");
			}
        }
    }
}
