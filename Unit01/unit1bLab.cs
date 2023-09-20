using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What's the weather in celcius today? ");
		var number = Console.ReadLine();
		int value = Convert.ToInt32(number);
		CheckWeather(value);
	}
	
	public void CheckWeather (int degree) {
		if (degree >= 30){
			Console.WriteLine("Wear something light. ");
		}
		else {
			Console.WriteLine("Wear something heavy. ");
		}
	}
}