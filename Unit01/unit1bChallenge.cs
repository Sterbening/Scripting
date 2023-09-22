using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What's the weather in celcius today? "); // Asking question in command line
		string number = Console.ReadLine(); // Reading user input
		float value = Convert.ToSingle(number); // changing string into a float
		CheckWeather(value); // running the void function

        Console.WriteLine("What number grade did you get on your last test? "); // Asking question in command line
		string testscore = Console.ReadLine(); // Reading user input
		float testscorefloat = Convert.ToSingle(testscore); // changing string into a float
		CheckGrade(testscorefloat); // running the void function
		
		Console.WriteLine("What's your favorite subject? "); // Asking question in command line
		string subject = Console.ReadLine(); // Reading user input
		SubjectOption(subject); // running the void function
	}
	
	public void CheckWeather (float degree) { // Whenever CheckWeather is used it runs this function
		if (degree >= 60) { // Asking if user answer is greater than or equal to 60
			Console.WriteLine("You're very dead. ");
		}
		else if (degree >= 50) { // If answer is less than 60 it will print this string
			Console.WriteLine("You're dead. ");
		}
		else if (degree >= 40) { // If answer is less than 50 it will print this string
			Console.WriteLine("I suggest going to some body of water and having a blast! Make sure you wear sunscreen! Otherwise stay inside. ");
		}
		else if (degree >= 30) { // If answer is less than 40 it will print this string
			Console.WriteLine("Turn on the AC if you have it. If you have to go outside wear very light clothing or non at all. ");
		}
		else if (degree >= 20) { // If answer is less than 30 it will print this string
			Console.WriteLine("I suggest a T-shirt and shorts or pants today. ");
		}
		else if (degree >= 10) { // If answer is less than 20 it will print this string
			Console.WriteLine("I definitely recommend a light jacket or hoodie. It is going to be chilly. ");
		}
		else if (degree >= 0) { // If answer is less than 10 it will print this string
			Console.WriteLine("There might be snow on the ground to definitely wear a thick jacket and pants. If you have boots I suggest those as well. ");
		}
		else { // If answer is anything below 0 it will print this string
			Console.WriteLine("It's cold as hell! ");
		}
	}

    public void CheckGrade (float grade) { 
		if (grade >= 90) { 
			Console.WriteLine("You get an A!!!!!!!!!!!!!!!!!!! ");
		}
		else if (grade >= 80) { 
			Console.WriteLine("You get a B ~_~ ");
		}
		else if (grade >= 70) { 
			Console.WriteLine("You get a C >:( ");
		}
		else { 
			Console.WriteLine("YOU FAIL! ");
		}
	}
	
	public void SubjectOption (string selectedSubject) { // This is a fuction that takes a string and runs it through a switch function
		switch (selectedSubject) { // Takes users answer and matches it to a case. Then writes line for that case
			case "Math":
				Console.WriteLine("You're a nerd! ");
				break; 
			case "History":
				Console.WriteLine("History is my favorite subject as well! I like you. ");
				break;
			case "Science":
				Console.WriteLine("Oh you like science? Name every element. ");
				break;
			case "English":
				Console.WriteLine("Please don't argue with me. ");
				break;
			case "PE":
				Console.WriteLine("Let's hit the gym together. ");
				break;
			default: // If none of the cases are met, defaults to this line
				Console.WriteLine("That's not a subject.");
				break;
		}
	}
}
