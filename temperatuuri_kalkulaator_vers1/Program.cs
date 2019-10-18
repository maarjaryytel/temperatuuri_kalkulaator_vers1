using System;

namespace temperatuuri_kalkulaator_vers1
{
	class Program
	{
		static void Main(string[] args)
		{
			string userChoice;
			Console.WriteLine("Do You want to use the Fahrenheit or Celsius calculator? Make Your choice: ");
			userChoice = Console.ReadLine();
			Console.WriteLine("\n");

			if (userChoice == "Celsius")
			{
				double fahren;
				Console.WriteLine("Enter Your temperature in Celsius (°C): ");
				double celsius = Convert.ToDouble(Console.ReadLine());
				fahren = (celsius * 9) / 5 + 32;
				Console.WriteLine("The temperature in Fahrenheit (°F): " + (Math.Round(fahren, 1)));
			}
			else
			{
				double celsius;
				Console.WriteLine("Enter Your temperature in Fahrenheit (°F): ");
				double fahren = Convert.ToDouble(Console.ReadLine());
				celsius = (fahren - 32) * 5 / 9;
				Console.WriteLine("The temperature in Celsius is (°C): " + (Math.Round(celsius, 1)));
			}
			Console.ReadLine();
		}
	}
}
