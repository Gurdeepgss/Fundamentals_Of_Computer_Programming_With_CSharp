using System;

namespace QuotationsInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
			 * the \ character is used to escape "
			 */
			string nestedQuotations = "The \"use\" of quotations causes difficulties";
			/*
			 * the verbatim string prints \t as it is and therfore to print " in string "" are
			 * used
			 */
			string verbatimNestedQuotations = @"The ""use"" of quotations causes difficulties";
			string noNestedQuotes = "The use of quotations causes difficulties";

			Console.WriteLine(nestedQuotations);
			Console.WriteLine(verbatimNestedQuotations);
			Console.WriteLine(noNestedQuotes);
        }
    }
}
