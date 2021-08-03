
using System;


public class Program
{
	public static void Main()
	{
		int valor1 = 10;
		int valor2 = 15;
		
		int maiorValor = valor1 > valor2 ? valor1 : valor2;
		
		Console.WriteLine("Maior valor: " + maiorValor);
	}
}