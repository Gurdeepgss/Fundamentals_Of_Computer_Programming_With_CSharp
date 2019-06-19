using System;

namespace WhatBitOnPosition_11
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Program to print binary digit at pth position in number n");
			Console.WriteLine("position starts form 0");
			Console.WriteLine();
            Console.Write("Enter a number: ");
			int number = int.Parse(Console.ReadLine());

			Console.Write("Enter the position for which to get the binary digit: ");
			int position = int.Parse(Console.ReadLine());

			/*
			 * Algorithm: for any position, apply the bit shift right operator 'position - 1'
			 * times now the bit you want to get will be on position 1 or it will be the right
			 * most or the Least significant Bit. Do 'bitwise AND' of that number and 1 which
			 * will either return 0 or 1, if the result is 0 then the bit is 0 and if the
			 * result is 1 then the bit is 0
			 */

				number >>= (position);

				if((number & 1) == 1 )
				{
					Console.WriteLine($"Bit on position {position} is 1.\n");
				}
				else
				{
					Console.WriteLine($"Bit on position {position} is 0.\n");
				}
        }
    }
}
