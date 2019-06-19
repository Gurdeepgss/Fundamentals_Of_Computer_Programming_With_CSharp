using System;

namespace CompanyAndManager_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tThe Company and The Manager");

			Console.Write("Enter name of the Company: ");
			string companyName = Console.ReadLine();

			Console.Write("Enter address of the Company: ");
			string address = Console.ReadLine();

			Console.Write("Enter phone number of the Company: ");
			long phoneNumber = long.Parse(Console.ReadLine());

			Console.Write("Enter fax number of the Company: ");
			long faxNumber = long.Parse(Console.ReadLine());

			Console.Write("Enter website of the Company: ");
			string website = Console.ReadLine();

			Console.Write("Enter name of Manager of the Company: ");
			string managerName = Console.ReadLine();

			Console.Write("Enter surname of Manager of the Company: ");
			string managerSurname = Console.ReadLine();

			Console.Write("Enter phone number of Manager of the Company: ");
			long managerPhoneNumber = long.Parse(Console.ReadLine());

			Console.WriteLine();

			Console.WriteLine($"Name of the Company is: {companyName}");
			Console.WriteLine($"Address of the Company is: {address}");
			Console.WriteLine($"Phone number of the Company is: {phoneNumber}");
			Console.WriteLine($"Fax number of the Company is: {faxNumber}");
			Console.WriteLine($"Website of the Company is: {website}");
			Console.WriteLine($"Name of Manager of the Company is: {managerName}");
			Console.WriteLine($"Surname of Manager of the Company is: {managerSurname}");
			Console.WriteLine($"Phone number of Manager of the Company is: {managerPhoneNumber}");
        }
    }
}
