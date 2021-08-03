
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
		foreach(int nu in numbers)
		{
			Console.WriteLine(nu);
		}
		
		Console.WriteLine("Lambda:");
		
		int oddNumbers = numbers.Count(n => n % 2 == 1);
		Console.WriteLine("Quantidade de números ímpares: " + oddNumbers);
	}
}