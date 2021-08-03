using System;
					
public class Program
{
	public static void Main()
	{
		int div = 1000;
		while (div != 3)
		{
			div = div / 2;
			Console.WriteLine("Divisão é " + div);
		}	
	}
}