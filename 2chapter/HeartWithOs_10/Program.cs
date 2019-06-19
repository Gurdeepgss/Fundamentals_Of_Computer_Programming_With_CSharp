using System;

namespace heartWithOs_10
{
    class Program
    {
        static void Main(string[] args)
        {
			/* using @ sign before quotations, the escaping characters are displayed or printed
			 * as it is. The newlines, tab, quotes and other escaping characters are printed as
			 * it is */
			string heartWithOs = @"   
			       oo    oo  
			     o    o o   o
			    o      o     o
			    o            o
			     o          o
			      o        o
			       o      o
			        o    o
			         o  o
			          oo ";
			Console.WriteLine(heartWithOs);
        }
    }
}
