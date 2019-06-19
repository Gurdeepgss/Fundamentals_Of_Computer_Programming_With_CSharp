using System;

namespace ChangeBitInNumber_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to change bit at position \"p\" to bit \"v\" of number \"n\"");
			Console.WriteLine("Position starts form 0");
			Console.WriteLine();

			Console.Write("Enter the number: ");
			int number = int.Parse(Console.ReadLine());
			Console.Write("Enter the position to be changed: ");
			int position = int.Parse(Console.ReadLine());
			Console.Write($"Enter the new Value for position {position}: ");
			int newBitValue = int.Parse(Console.ReadLine());

			int tempNumber = number;
			tempNumber >>= position;
			int newNumber = 0;
				
			if((tempNumber & 1) == 1)
			{
				/*
				 * Math(2, position) function returns the number with it's bit at position
				 * "position" being 1 and at all other positions 0.
				 * For bit 1 to be converted to 0, we need a number whose bit configuration is
				 * 0 at position "position" and 1 for all other bits, this number is obrained
				 * by Bitwise negating the number (int)Math.Pow(2, position). Bitwise ANDing this
				 * number with original number gives the required result, as Bitwise AND of 1
				 * with 0 is 0 which is required and Bitwise AND of 1 with any bit will be
				 * equal to that same bit.
				 *
				 */

				/*
				 *	Implementation on Book:
				 *	shifting left the bits of 1 by position "position" is same as
				 *	Math(2, position)
				 */
				if(newBitValue == 0)
					newNumber = number & (~(int)Math.Pow(2, position));
				else if(newBitValue == 1)
					newNumber = number | 0;
			}
			else
			{
				if(newBitValue == 1)
				/*
				 * Math(2, position) function returns the number with it's bit at position
				 * "position" being 1 and at all other positions 0.
				 * For bit 0 to be converted to 1, we need a number whose bit configuration is
				 * 1 at position "position" and 0 for all other bits, this number is obrained
				 * from the number (int)Math.Pow(2, position). Bitwise ORing this
				 * number with original number gives the required result, as Bitwise OR of 0
				 * with 1 is 1 which is required and Bitwise OR of 0 with any bit will be
				 * equal to that same bit.
				 */
					newNumber = number | (int)Math.Pow(2, position);
				else if(newBitValue == 0)
					newNumber = number | 0;
			}
			Console.WriteLine($"The number {number} after converting position {position} bit to {newBitValue} is {newNumber}");
		}
    }
}
