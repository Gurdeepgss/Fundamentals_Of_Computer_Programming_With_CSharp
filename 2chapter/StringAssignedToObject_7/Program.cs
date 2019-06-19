using System;

namespace StringAssignedToObject
{
    class Program
    {
        static void Main(string[] args)
        {
			string hello = "Hello";
			string world = "World";

			/* Object data-type in C# is parent data-type of all data-types, which is why data
			 * of any type can be assigned to object. But as you can try to execute this
			 * program, it's output is quiet slow */
			object helloWorld = hello + " " + world;
			Console.WriteLine(helloWorld);
        }
    }
}
