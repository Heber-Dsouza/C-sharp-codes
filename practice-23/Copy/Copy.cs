using System;

class Copy{

  static void Main(){

    int[] vetor = {11, 22, 33, 44, 55};
    int[] copiaVetor = new int[5];

    Console.Clear();
    Console.WriteLine("Copy");
    Console.WriteLine("O valor do vetor é:");

    foreach (int n in vetor){
      Console.WriteLine(n);
    }

    //------------------------------------------------------------------------------

    //public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
    Console.WriteLine("----------------------------------------------------");
    Array.Copy(vetor, copiaVetor, vetor.Length);

    Console.WriteLine("O valor do copiaVetor é:");

    foreach (int n in copiaVetor){
      Console.WriteLine(n);
    }

  }
}