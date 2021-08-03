using System;

namespace Atividade
{
  class Program
  {
    static void Main(string[] args)
    {
      //Boxing
      int i = 123;
      object obj = i;
      Console.WriteLine(obj);
      
      //Unboxing
      object objj = 321;
      int ii = (int)objj;
      Console.WriteLine(ii);
      
      
    }
    
  }
}