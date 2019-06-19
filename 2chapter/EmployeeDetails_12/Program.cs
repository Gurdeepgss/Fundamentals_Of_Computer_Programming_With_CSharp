using System;

namespace EmployeeDetails_12
{
    class Program
    {
        static void Main(string[] args)
        {
			Employee karen = new Employee();	
			karen.PrintEmployee();
        }
    }

	class Employee
	{
		string firstName = "Karen";
		string lastName = "Pot";
		int age = 29;
		char gender = 'F';
		int employeeNumber = 27560000;

		public void PrintEmployee()
		{
			Console.WriteLine($"First Name: {firstName}.");
			Console.WriteLine($"Last Name: {lastName}.");
			Console.WriteLine($"Age: {age}.");
			Console.WriteLine($"Gender: {gender}.");
			Console.WriteLine($"Unique Employee number: {employeeNumber}.");
		}
	}
}
