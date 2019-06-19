using System;

namespace SequencePrint_10
{
    class Program
    {
        static void Main(string[] args)
        {
			int nextValue = 2;
			for(int index = 1; index <= 100; index++)
			{
				Console.Write($"{index}. {nextValue}\t\t");

				if(nextValue < 0)
					nextValue *= -1;

				if(++nextValue % 2 != 0)
				{
					nextValue *= -1;
				}

				/* for printing in newline after four terms are printed */
				if(index % 4 == 0)
					Console.WriteLine();
			}
        }
    }
}
