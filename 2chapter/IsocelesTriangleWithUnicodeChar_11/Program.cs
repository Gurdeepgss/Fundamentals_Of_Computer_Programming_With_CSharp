using System;

namespace isocelesTriangleWithUnicodeChar_11
{
    class Program
    {
        static void Main(string[] args)
        {
			char copyrightSymbol = '\u00A9';
			char c = copyrightSymbol;
			/* the "$" symbols allows us to have interpolated string i.e. string with use of
			 * {variable} which allows use of variables inside the quotes. the {variable} is
			 * replaced by the value of the variable in the console output */
			/* the "@" allows us to have a verbatim string i.e. a string that prints the
			 * escaping characters as it is, all the newlines, tabs, quotes etc. */
			string isocelesTriangleWithUnicodeChar = $@"
                                 {c}
                                {c} {c}
                               {c}   {c}
                              {c}     {c}
                             {c}       {c}
                            {c}         {c}
                           {c} {c} {c} {c} {c} {c} {c}";

			Console.WriteLine("Equalateral triangle using unicode copyright symbol");
			Console.WriteLine(isocelesTriangleWithUnicodeChar);
			Console.WriteLine();
        }
    }
}
