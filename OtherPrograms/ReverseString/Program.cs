using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get your String reversed");

			Console.Write("Enter string: ");
			string toBeReversed = Console.ReadLine();

			char[] inCharToBeReversed = toBeReversed.ToCharArray();
			Array.Reverse(inCharToBeReversed);
			string reversed = new string(inCharToBeReversed);
			
			Console.WriteLine($"\"{toBeReversed}\" reversed is \"{reversed}\".");
        }
    }
}
