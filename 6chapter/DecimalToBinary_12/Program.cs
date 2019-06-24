using System;

namespace DecimalToBinary_12
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
			 * This Program only converts an an integer or non-floating number to corresponding
			 * binary number 
			 */
            Console.WriteLine("Conversion from Decimal to Binary");

			Console.Write("Enter a decimal number: ");
			double originalDecimalNumber = double.Parse(Console.ReadLine());

			double decimalNumber = originalDecimalNumber;
			double quotient = 0;
			string stringRemainder = "";
			byte charRemainder = 0;
			while ( !((quotient == 1) && (charRemainder == 0 || charRemainder == 1)) )
			{
				quotient = (int)(decimalNumber / 2);
				charRemainder = (byte)( decimalNumber % 2 );
				stringRemainder += "" + charRemainder;

				decimalNumber = quotient;
			}
			stringRemainder += decimalNumber;

			char[] toBeReversed = stringRemainder.ToCharArray();
			Array.Reverse(toBeReversed);
			string binaryNumberString = new string(toBeReversed);
			/* double binaryNumber = double.Parse(binaryNumberString); */

			Console.WriteLine($"{originalDecimalNumber} in binary is {binaryNumberString}.");
        }
    }
}
