using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What's the weather in celcius today? "); // Asking question in command line
		var number = Console.ReadLine(); // Reading user input
		int value = Convert.ToInt32(number); // Changing string into int
		CheckWeather(value); // running the void function
	}
	
	public void CheckWeather (int degree) { // Whenever CheckWeather is used it runs this function
		if (degree >= 30) { // Asking is user answer is greater than or equal to 30
			Console.WriteLine("Wear something light. ");
		}
		else { // if not greater than or equal to 30 then writing this string
			Console.WriteLine("Wear something heavy. ");
		}
	}
}