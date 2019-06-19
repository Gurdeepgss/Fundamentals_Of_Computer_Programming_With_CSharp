using System;

namespace PrintCurrentDateAndTime_8
{
    class Program
    {
        static void Main(string[] args)
        {
			DateTime now = DateTime.Now;
            Console.WriteLine($"It's {now} now.\n");
        }
    }
}
