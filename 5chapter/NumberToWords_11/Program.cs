using System;

namespace NumberToWords_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prints Numbers (0-999) to Words");

			Console.Write("Enter a number (0-999): ");
			short number = short.Parse(Console.ReadLine());

			string zero = "Zero";
			string one = "one";
			string two = "two";
			string three = "three";
			string four = "four";
			string five = "five";
			string six = "six";
			string seven = "seven";
			string eigh = "eigh";
			string nine = "nine";
			string ten = "ten";
			string eleven = "eleven";
			string twelve = "twelve";
			string thir = "thir";
			string fif = "fif";
			string twenty = "twenty";
			string hundred = "hundred";
			string t = "t";
			string teen = "teen";
			string ty = "ty";

			short hundreds = (short)((number / 100) % 10);
			short tens = (short)((number / 10) % 10);
			short ones = (short)(number % 10);
			string numberInWords = "";

			if(number >= 0 && number < 1000)
			{
				switch(hundreds)
				{
					case 0:
						break;
					case 1:
						numberInWords = one + " " + hundred;
						break;
					case 2:
						numberInWords = two + " " + hundred;
						break;
					case 3:
						numberInWords = three + " " + hundred;
						break;
					case 4:
						numberInWords = four + " " + hundred;
						break;
					case 5:
						numberInWords = five + " " + hundred;
						break;
					case 6:
						numberInWords = six + " " + hundred;
						break;
					case 7:
						numberInWords = seven + " " + hundred;
						break;
					case 8:
						numberInWords = eigh + t + " " + hundred;
						break;
					case 9:
						numberInWords = nine + " " + hundred;
						break;
				}

				switch(tens)
				{
					case 0:
						break;
					case 2:
						numberInWords += " " + twenty;
						break;
					case 3:
						numberInWords += " " + thir + ty;
						break;
					case 4:
						numberInWords += " " + four + ty;
						break;
					case 5:
						numberInWords += " " + fif + ty;
						break;
					case 6:
						numberInWords += " " + six + ty;
						break;
					case 7:
						numberInWords += " " + seven + ty;
						break;
					case 8:
						numberInWords += " " + eigh + ty;
						break;
					case 9:
						numberInWords += " " + nine + ty;
						break;
				}

				if(tens != 0 && tens != 1)
				{
					switch(ones)
					{
						case 1:
							numberInWords += " " + one;
							break;
						case 2:
							numberInWords += " " + two;
							break;
						case 3:
							numberInWords += " " + three;
							break;
						case 4:
							numberInWords += " " + four;
							break;
						case 5:
							numberInWords += " " + five;
							break;
						case 6:
							numberInWords += " " + six;
							break;
						case 7:
							numberInWords += " " + seven;
							break;
						case 8:
							numberInWords += " " + eigh + t;
							break;
						case 9:
							numberInWords += " " + nine;
							break;
					}
				}

			}

			if(tens == 1)
			{
				switch(ones)
				{
					case 0:
						numberInWords += " " + ten;
						break;
					case 1:
						numberInWords += " " + eleven;
						break;
					case 2:
						numberInWords += " " + twelve;
						break;
					case 3:
						numberInWords += " " + thir + teen;
						break;
					case 4:
						numberInWords += " " + four + teen;
						break;
					case 5:
						numberInWords += " " + fif + teen;
						break;
					case 6:
						numberInWords += " " + six + teen;
						break;
					case 7:
						numberInWords += " " + seven + teen;
						break;
					case 8:
						numberInWords += " " + eigh + teen;
						break;
					case 9:
						numberInWords += " " + nine + teen;
						break;
				}

				if(hundreds == 0 && tens == 0 && ones == 0)
				{
					numberInWords = zero;
				}

				Console.WriteLine($"Number {number} is: {numberInWords}.");
			}	
			else
			{
				Console.WriteLine($"{number} is not a valid number, Enter between 0-999.");
			}
        }
    }
}
