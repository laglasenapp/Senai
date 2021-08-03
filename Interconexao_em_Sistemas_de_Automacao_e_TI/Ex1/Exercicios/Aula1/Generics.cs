
using System;
using System.Collections.Generic;

public class Pessoa
{
	
	public string Nome { get; set; }
	public int Idade { get; set; }
	public string Sexo { get; set; }
	
	public Pessoa(string nome, int idade, string sexo)
	{
		Nome = nome;
		Idade = idade;
		Sexo = sexo;
	}	
	
	public Pessoa()
	{		
	}
	
	
	public static void Main()
	{
		List<Pessoa> listaPessoas = new List<Pessoa>();
		
		Pessoa pessoaTeste = new Pessoa();
		pessoaTeste.Nome = "Luiz";
		pessoaTeste.Idade = 26;
		pessoaTeste.Sexo = "M";
		
		listaPessoas.Add(pessoaTeste);
		
		Console.WriteLine(listaPessoas.Count);
		
	}
}