using System;

namespace LCM_GCD_By_thicckWire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two Natural-numbers i.e. [1, 2, 3, 4, ...] to find their Greatest Common Divisor and L.C.M.: ");
			int pehla = int.Parse(Console.ReadLine());
			int dooja = int.Parse(Console.ReadLine());

			// the "?" here represents Nullable type i.e. the variable can hold null value,
			// which otherwise witout "?" couldn't
			int? greatestCommonDivisor = 1; 
			int? lcm = LCM(pehla, dooja, out greatestCommonDivisor);

			Console.WriteLine($"Greatest Common Divisor of {pehla} and {dooja} is: {greatestCommonDivisor}");
			Console.WriteLine($"L.C.M. of {pehla} and {dooja} is: {lcm}");
        }

		/*
		 * The basic Algorithm i.e. mentioned throughout the comments in LCM function
		 * is taken from: https://www.singingturtle.com/2010/09/how-to-find-the-lcm-fast/
		 */
		static int? LCM(int pehla, int dooja, out int? greatestCommonDivisor)
		{
			bool done = false;		//default value for a boolean variable is false
			int divisor = 1;
			/* gDYet = Greatest Divisor Yet */
			int gDYetForPehla = 1;
		    int	gDYetForDooja = 1;
			int gDYet = 1;
			greatestCommonDivisor = 1;
			int? lcm = 1;

			if(pehla >= divisor && dooja >= divisor)
			{
				//calculate greatest common factor of two numbers
				while(!done)
				{
					gDYetForPehla = (pehla % divisor == 0)? divisor : gDYetForPehla;
					gDYetForDooja = (dooja % divisor == 0)? divisor : gDYetForDooja;

					gDYet = (gDYetForPehla == gDYetForDooja)? gDYetForPehla : gDYet;

					if(gDYetForPehla == pehla || gDYetForDooja == dooja)
					{
						greatestCommonDivisor = gDYet;
						done = true;
					}
					++divisor;
				}

				//divide the greatest common factor by any one of the numbers(we choose "pehla" in
				//this case to get the "Quotient"
				int quotient = (int)(pehla / greatestCommonDivisor);

				//multiply the answer from previous calculation with "dooja"
				// the "?" here represents Nullable type i.e. the variable can hold null value,
				// which otherwise witout "?" couldn't
				lcm = dooja * quotient;
			}
			/*
			 * In case user inputs a negative or 0
			 */
			else
			{
				/* Because they are declared of Nullable-type */
				greatestCommonDivisor = null;
				lcm = null;

				Console.WriteLine("Please Enter only Natural numbers i.e. [1, 2, 3, 4, ...] for L.C.M. calculation.");
			}
			return lcm;
		}
    }
}
