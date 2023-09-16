using System;
					
public class Program
{
	public static int sum1 = 100 + 50;
	public static int sum2 = sum1 + 100;
	public static int sum3 = sum2 + 150;
	static int sum4 = sum3 * 10;
	public static float float_num = 3.4f;
	
	static string name = "Calvin";
	
	static bool numBool = true; 
	
	public static void Main()
	{
		Console.WriteLine(sum4 / sum3);
		Console.WriteLine(sum1 * sum2);
		Console.WriteLine(float_num * sum3);
		Console.WriteLine("Hello World");
		Console.WriteLine(name);
		Console.WriteLine("Hi " + name);
		
		//If sum4 > sum3, code will be ran
		if (sum4 > sum3)
		{
			Console.WriteLine("sum4 is greater than sum3");
		}
		//If numBool is true, code will be ran
			if (numBool)
		{
			Console.WriteLine("numBool is true");
		}

	}
}