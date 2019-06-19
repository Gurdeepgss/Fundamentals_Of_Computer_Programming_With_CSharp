using System;

namespace Unicode72InChar_5
{
    class Program
    {
        static void Main(string[] args)
        {
			/* the '\uXXXX' pattern is used to denote the unicode for a character in the
			 * unicode character table, here X is any number that leads to a correct unicode
			 * character */
			char unicode72 = '\u0072';
            Console.WriteLine(unicode72);
        }
    }
}
