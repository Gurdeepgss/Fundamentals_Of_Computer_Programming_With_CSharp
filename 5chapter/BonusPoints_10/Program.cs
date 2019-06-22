using System;

namespace BonusPoints_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Bonus Points");

			Console.Write("Enter your score (1-9): ");
			byte score = byte.Parse(Console.ReadLine());
			short promotedScore = score;

			switch(score)
			{
				case 1:
				case 2:
				case 3:
					promotedScore *= 10;
					Console.WriteLine($"Score {score} is promoted to {promotedScore}.");
					break;
				case 4:
				case 5:
				case 6:
					promotedScore *= 100;
					Console.WriteLine($"Score {score} is promoted to {promotedScore}.");
					break;
				case 7:
				case 8:
				case 9:
					promotedScore *= 1000;
					Console.WriteLine($"Score {score} is promoted to {promotedScore}.");
					break;
				default:
					Console.WriteLine($"Score {score} is not valid.");
					break;
			}
        }
    }
}
