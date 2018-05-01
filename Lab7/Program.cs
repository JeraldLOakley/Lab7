using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
	class Program
	{
		static void Main(string[] args)
		{
			Welcome();
			Phone();
			Date();
			Email();
			Name();
			Goodbye();

		}

		static void Welcome()
		{
			Console.WriteLine("Hello, we would like to validate some of your information");
		}


		static bool IsName(string Name)
		{
			return Regex.IsMatch(Name, @"\b[A-Z][a-z]{0,30}\b");
		}

		static void Name()
		{
			while (true)
			{
				Console.WriteLine("Please enter a valid Name");
				Console.WriteLine("Must start with a capital and be no longer than 30 characters");
				string NameVal = Console.ReadLine();

				if ((IsName(NameVal)))
				{
					Console.WriteLine("Name is valid");
					return;
				}
				else
				{
					Console.WriteLine("Name is not valid");
				}
			}
		}

		static bool IsEmail(string Email)
		{
			return Regex.IsMatch(Email, @"\b[\w][^_]{5,30}@[\w]{5,10}.\w{2,3}\b");
		}

		static void Email()
		{
			while (true)
			{
				Console.WriteLine("Please enter a valid email");
				Console.WriteLine("Email name must not contain special characters");
				string EmailVal = Console.ReadLine();

				if ((IsEmail(EmailVal)))
				{
					Console.WriteLine("This is a valid email address");
					return;
				}
				else
				{
					Console.WriteLine("This is not a valid email address");
				}
			}
		}

		static bool IsPhone(string Phone)
		{
			return Regex.IsMatch(Phone, @"\b(\d{3}[-]){2}\d{4}\b");
		}

		static void Phone()
		{
			while (true)
			{
				Console.WriteLine("Please enter a valid phone number");
				Console.WriteLine("Phone number example 111-111-1111");
				string PhoneNumber = Console.ReadLine();
				bool MoveOn = true;


				if ((IsPhone(PhoneNumber)))
				{
					Console.WriteLine("This is a valid phone number");
					return;
				}
				else
				{
					Console.WriteLine("This is not a valid number");
				}
			}
		}

		static bool IsDate(string Date)
		{
			return Regex.IsMatch(Date, @"\b(\d{2}[/]){2}\d{4}\b");
		}
		static void Date()
		{
			while (true)
			{
				Console.WriteLine("Please enter a valid date");
				Console.WriteLine("Date must be in dd/mm/yyyy format");
				string Dateformat = Console.ReadLine();

				if ((IsDate(Dateformat)))
				{
					Console.WriteLine("Is a valid date");
					return;
				}
				else
				{
					Console.WriteLine("Not a valid date");
				}
			}
		}
		static void Goodbye()
		{
			Console.WriteLine("All of your information is valid, have a nice day");
		}

	}
}
