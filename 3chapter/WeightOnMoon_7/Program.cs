using System;

namespace WeightOnMoon_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tCalculate your weight on moon\n");

			Console.Write("Enter your weight on Earth: ");
			float weightOnEarth = float.Parse(Console.ReadLine());

			/*
			 * float weightOnMoon = weightOnEarth * (float)(17 / 100);
			 * This does not work as the integer division takes place in 17 / 100, which
			 * returns an integer, which then is explicitly converted to float whose fractional
			 * part is 0
			 *
			 * float weightOnMoon = weightOnEarth * ( (float)17 / 100 ); 
			 * In this first 17 is explicitly converted to float, now the division 17 / 100 is
			 * no longer an integer division, hence the answer computed is correct
			 */
			float weightOnMoon = weightOnEarth * ( (float)17 / 100 );

			Console.WriteLine($"Your weight on Moon is {weightOnMoon}");
        }
    }
}
