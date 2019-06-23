using System;

namespace MatrixPatternSizeN_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix pattern");

			for(int row = 0; row < 3; row++)
			{
				for(int column = row; column < row + 3; column++)
				{
					Console.Write($"{column + 1, 3}");
				}
				Console.WriteLine();
			}
        }
    }
}
