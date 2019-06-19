using System;

namespace ThirdBit0or1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check it's third bit(from right): ");
			int userInput = int.Parse(Console.ReadLine());

			/*
			 * Here the bit configuration is assumed to be starting from position 1st from
			 * right
			 *
			 * the bit configuration of 4 is "100" any number of 0 bits to the left of 1 can be
			 * added, the value remains the same. Bitwise AND of this bit configuration with
			 * any other will result in 0's in all positions except the third position from
			 * right. The result of position(third position from right in bit configuration)
			 * will depend on the other operand of the AND, if the other operand contains 1 in
			 * that bit position then the result will be "1" and otherwise it will be "0",
			 * which in terms of integer means number 4.
			 */
			int isItOne = (int)(userInput & 4);
			if(isItOne == 0)
				Console.WriteLine($"{userInput}'s third bit from right is 0.");
			else if(isItOne == 4)
				Console.WriteLine($"{userInput}'s third bit from right is 1.");
        }
    }
}
