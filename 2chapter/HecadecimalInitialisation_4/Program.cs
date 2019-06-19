using System;

namespace HecadecimalInitialisation_4
{
    class Program
    {
        static void Main(string[] args)
        {
			/* the int variable "hex100OrInt256" is initialised by a hexadecimal format number
			 * 0x100 which is implicitly converted to int data-type and the corresponding value
			 * of 0x100 in int is 256 */
			int hex100OrInt256 = 0x100;

			Console.WriteLine(hex100OrInt256);
        }
    }
}
