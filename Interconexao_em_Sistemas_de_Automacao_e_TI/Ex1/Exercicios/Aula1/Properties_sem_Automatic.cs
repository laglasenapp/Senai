
using System;


public class Program
{
	
	private string _cor;
	
	public string Cor
	{
		get { return _cor; }
		set { _cor = value; }
	}
	
	public static void Main()
	{
		Program Program = new Program();
		Program.Cor = "Preto";
		
		Console.WriteLine("Maior valor: " + Program.Cor);
	}
}