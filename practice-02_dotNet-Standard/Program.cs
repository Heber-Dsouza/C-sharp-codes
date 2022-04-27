using System;

namespace Practice02 {

  class Program{

    static void Main(string[] args){
      Console.Write("Lourenço");

      if(args.GetLength(0) > 0)
      Console.Write(args.GetValue(0));
    }
  }
}