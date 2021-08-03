
using System;
using System.Collections.Generic;
using System.Linq;

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
		
		Pessoa pessoaTeste1 = new Pessoa();
		pessoaTeste1.Nome = "Marcides";
		pessoaTeste1.Idade = 55;
		pessoaTeste1.Sexo = "M";		
		listaPessoas.Add(pessoaTeste1);
		
		Pessoa pessoaTeste2 = new Pessoa();
		pessoaTeste2.Nome = "Doraci";
		pessoaTeste2.Idade = 50;
		pessoaTeste2.Sexo = "F";		
		listaPessoas.Add(pessoaTeste2);
		
		Console.WriteLine("Quantidade de pessoas: " + listaPessoas.Count);
		
		
		
		List<Pessoa> listaOrdenadaPessoas = listaPessoas.OrderByDescending(x => x.Nome).ToList(); 
		Console.WriteLine("Lista ordenada:");
		listaOrdenadaPessoas.ForEach(n => Console.WriteLine(n.Nome));
		
		Console.WriteLine("Filtro:");		
		List<Pessoa> listaSelecionada = (from Pessoa p in listaOrdenadaPessoas where p.Nome == "Luiz" select p).ToList();
		listaSelecionada.ForEach(n => Console.WriteLine(n.Nome));
		
		
		int totalIdades = listaOrdenadaPessoas.Sum(x => x.Idade);
		Console.WriteLine("Idades somadas: " + totalIdades);
		
		
	}
}