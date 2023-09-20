using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What's the weather in celcius today? "); // Asking question in command line
		var number = Console.ReadLine(); // Reading user input
		int value = Convert.ToInt32(number); // Changing string into int
		CheckWeather(value); // running the void function

        Console.WriteLine("What number grade did you get on your last test? "); // Asking question in command line
		string testscore = Console.ReadLine(); // Reading user input
		float testscorefloat = Convert.ToSingle(testscore); // changing string into a float
		CheckGrade(testscorefloat); // runing the void function
	}
	
	public void CheckWeather (int degree) { // Whenever CheckWeather is used it runs this function
		if (degree >= 30) { // Asking is user answer is greater than or equal to 30
			Console.WriteLine("Wear something light. ");
		}
		else { // if not greater than or equal to 30 then writing this string
			Console.WriteLine("Wear something heavy. ");
		}
	}

    public void CheckGrade (float grade) { // Whenever CheckGrade is used it runs this void function
		if (grade > 90) { // if answer is greater than 90 then output next string
			Console.WriteLine("You get an A!!!!!!!!!!!!!!!!!!! ");
		}
		else if (grade > 80) { // if answer is greater than 80 output next string
			Console.WriteLine("You get a B ~_~ ");
		}
		else if (grade > 70) { // if answer is greater than 70 output next string
			Console.WriteLine("You get a C >:( ");
		}
		else { // if answer is anything else output next string
			Console.WriteLine("YOU FAIL! ");
		}
	}
}