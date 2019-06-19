using System;

namespace AppropriateTypeForAppropriateLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
			/* the data-type is such that it is "just" big enough to hold the value it has been
			 * initialised to. for e.g.: "short yearOfBirth = 1990;" cannot be stored in a byte.
			 * Similarly "long largeNumber = 123456789123456789" cannot be stored in any
			 * data-type smaller than long */
			/* try changing the data-types to smaller data-types. also try changing signing of
			 * the data-types */

			sbyte tempInCanada = -44;
			byte marksInMathematics = 97;
			byte tempInFahrenheit = 112;
			sbyte tempInAntartica = -115;
			byte priceOfBook = 224;
			short yearOfBirth = 1990;
			short negativeTenThousand = -10000;
			short twentyThousand = 20000;
			int bikePrice = 52130;
			int debt = -1000000;
			int about4million = 4825932;
			int about970Million = 970700000;
			long largeNumber = 123456789123456789;

			Console.WriteLine(tempInCanada);
			Console.WriteLine(marksInMathematics);
			Console.WriteLine(tempInFahrenheit);
			Console.WriteLine(tempInAntartica);
			Console.WriteLine(priceOfBook);
			Console.WriteLine(yearOfBirth);
			Console.WriteLine(negativeTenThousand);
			Console.WriteLine(twentyThousand);
			Console.WriteLine(bikePrice);
			Console.WriteLine(debt);
			Console.WriteLine(about4million);
			Console.WriteLine(about970Million);
			Console.WriteLine(largeNumber);
        }
    }
}
