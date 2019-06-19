using System;

namespace SwapIntValues_13
{
    class Program
    {
        static void Main(string[] args)
        {
			int five = 5;
			int ten = 10;
			int swapSum = five + ten;

			Console.WriteLine($"The original values are: five = {five}  ten = {ten}");
			/* Interesting isn't it, the code written inside {} works as if it was outside of
			 * the "" quotes. For what I have used earlier {} was just with single variables,
			 * it's my first time using them with an expression */
			Console.WriteLine($"The swapped values are: five = {swapSum - five}  ten = {swapSum - ten}");
        }
    }
}
