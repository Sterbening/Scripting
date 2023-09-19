using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome");
		DoMath(3, 5);
		DoMath(55, 8);
		DoMath(33, 33);
	}
	public void DoMath (int value1, int value2) {
		var number = value1 + value2;
		Console.WriteLine(number);
	}
}