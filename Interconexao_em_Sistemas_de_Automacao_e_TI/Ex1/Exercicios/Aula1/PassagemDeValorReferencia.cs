using System;

namespace Atividade
{
  class Program
  {
    static void Main(string[] args)
    {
      int MeuInteiro = 10;
      Console.WriteLine(MeuInteiro);
      
      
      Program Program = new Program();
      Program.FuncaoPorValor(MeuInteiro);
      Console.WriteLine(MeuInteiro);
      Program.FuncaoPorReferencia(ref MeuInteiro);
      Console.WriteLine(MeuInteiro);
      
      
    }
    
    public void FuncaoPorValor(int numero){
    	numero = numero + 10;
    }
    
    public void FuncaoPorReferencia(ref int numero){
    	numero = numero + 10;
    }
  }
}