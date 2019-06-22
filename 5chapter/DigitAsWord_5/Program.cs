using System;

namespace DigitAsWord_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Digit as Word");

			Console.Write("Enter a number between 0-9: ");
			byte number = byte.Parse(Console.ReadLine());

			string wordNumber = "";
			switch(number)
			{
				case 0:
					wordNumber = "is Zero.";
					break;
				case 1:
					wordNumber = "is One.";
					break;
				case 2:
					wordNumber = "is Two.";
					break;
				case 3:
					wordNumber = "is Three.";
					break;
				case 4:
					wordNumber = "is Four.";
					break;
				case 5:
					wordNumber = "is Five.";
					break;
				case 6:
					wordNumber = "is Six.";
					break;
				case 7:
					wordNumber = "is Seven.";
					break;
				case 8:
					wordNumber = "is Eight.";
					break;
				case 9:
					wordNumber = "is Nine.";
					break;
				default:
					wordNumber = "is not a valid number.";
					break;
			}

			Console.WriteLine($"\"{number}\" {wordNumber}");
        }
    }
}
