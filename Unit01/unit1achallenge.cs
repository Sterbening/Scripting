using System;
					
public class Program
{
	static int num1 = 25;
	static int num2 = 11;
	static int num3 = 65;

	static double num4 = 1.5;
	static double num5 = 0.5;

	static bool bool1 = true;
	static bool bool2 = false;

	static string string1 = "Hi ";
	static string string2 = "My name is Calvin,";
	static string string3 = " how are you?";
	// Declaring all information
	public static void Main()
	{
		Console.WriteLine(num1 + num2); // Equate to 36
		Console.WriteLine(num3 - num1); // Equate to 40
		Console.WriteLine(num4 * num5); // Equate to 0.75
		Console.WriteLine(num3 / num4); // Equate to 43.3333333333333
		
		 // Type your name and press enter
     	Console.WriteLine("Enter name:"); // Printing a line asking for a name
     	string userName = Console.ReadLine(); // This is where you actually input the name
     	Console.WriteLine("Name is: " + userName); // This will show your name
		
		Console.WriteLine(string1 + userName); // Response to your name
		Console.WriteLine(string2 + string3); // Response to your name
		
		 // Enter you answer to the question
		Console.WriteLine("Enter Answer"); // Asking for your answer to the question
		string userAnswer = Console.ReadLine(); // User inputs thier answer
		Console.WriteLine(userAnswer); // Printing answer
	}
}