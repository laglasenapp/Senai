using System;
					
public class Program
{
	public static void Main()
	{
		int num = 10;
		do
		{
			num += 5;
			Console.WriteLine("Valor do número é " + num);
		}
		while (num > 100);
	}
}