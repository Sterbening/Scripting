using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("What's the weather in celcius today? "); 
		string number = Console.ReadLine(); 
		float value = Convert.ToSingle(number); 
		CheckWeather(value); 

        Console.WriteLine("What number grade did you get on your last test? "); 
		string testscore = Console.ReadLine(); 
		float testscorefloat = Convert.ToSingle(testscore); 
		CheckGrade(testscorefloat);
		
		Console.WriteLine("What's your favorite subject? ");
		string subject = Console.ReadLine();
		SubjectOption(subject);
	}
	
	public void CheckWeather (float degree) { 
		if (degree > 60) { 
			Console.WriteLine("You're very dead. ");
		}
		else if (degree > 50) { 
			Console.WriteLine("You're dead. ");
		}
		else if (degree > 40) {
			Console.WriteLine("I suggest going to some body of water and having a blast! Make sure you wear sunscreen! Otherwise stay inside. ");
		}
		else if (degree > 30) {
			Console.WriteLine("Turn on the AC if you have it. If you have to go outside wear very light clothing or non at all. ");
		}
		else if (degree > 20) {
			Console.WriteLine("I suggest a T-shirt and shorts or pants today. ");
		}
		else if (degree > 10) {
			Console.WriteLine("I definitely recommend a light jacket or hoodie. It is going to be chilly. ");
		}
		else if (degree > 0) {
			Console.WriteLine("There might be snow on the ground to definitely wear a thick jacket and pants. If you have boots I suggest those as well. ");
		}
		else if (degree > -10) {
			Console.WriteLine("Turn on the AC if you have it. If you have to go outside wear very light clothing or non at all. ");
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
	
	public void SubjectOption (string selectedSubject) {
		switch (selectedSubject) {
			case "Math":
				Console.WriteLine("You're a nerd! ");
				break; 
			case "History":
				Console.WriteLine("I like you ");
				break;
			case "Science":
				Console.WriteLine("You like science. Congrats ");
				break;
			case "English":
				Console.WriteLine("Please don't argue with me. ");
				break;
			case "PE":
				Console.WriteLine("Let's hit the gym together. ");
				break;
			default:
				Console.WriteLine("That's not a subject.");
				break;
		}
	}
}
