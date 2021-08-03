
using System;


public class Program
{
	
	public string Cor { get; set; }
	
	//propriedade readonly
	private int _qtd;
	
	public int qtd
	{
		get { return _qtd; }	
	}
	
	  
	
	public static void Main()
	{
		Program Program = new Program();
		Program.Cor = "Preto";
		
		Console.WriteLine("Maior valor: " + Program.Cor);
		
		// Compilation error (line 28, col 3): Property or indexer 'Program.qtd' cannot be assigned to -- it is read only
		//Program.qtd = 10;
		Console.WriteLine("Maior valor: " + Program.qtd);
	}
}