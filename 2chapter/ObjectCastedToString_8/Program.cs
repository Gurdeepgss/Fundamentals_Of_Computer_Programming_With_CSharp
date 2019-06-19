using System;

namespace ObjectCastedToString_8
{
    class Program
    {
        static void Main(string[] args)
        {
			string hello = "Hello";
			string world = "World";
			object helloWorldObject = hello + " " + world;
			/* object type is converted into string using explicit type casting */
			string helloWorldString = (string)helloWorldObject;

			Console.WriteLine(helloWorldString);
        }
    }
}
