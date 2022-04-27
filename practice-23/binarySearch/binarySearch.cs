using System;

class BinarySearch{

  static void Main(){

    int[] vetor = {11,22,33,44,55};

    // int[,] vetor4 = new int[2,5]{{11,22,00,44,55}, {66,77,88,99,00}};

    Console.Clear();
    Console.WriteLine("O valor do vetor é:");

    foreach(int n in vetor){
      Console.WriteLine(n);
    }

    Console.Write("Digite o valor que você quer procurar: ");
    int procurado = int.Parse(Console.ReadLine());


    //------------------------------------------------------------------------------

    //public static int BinarySearch(array,valor);
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("BinarySearch:");
    int position = Array.BinarySearch(vetor, procurado);
    
    if(position < 0){
      Console.WriteLine("O valor pesquisado não se encontra nesse array...");

    } else {
      Console.WriteLine("O Valor {0} está na posição {1}", procurado, position+1);
    }

  }
}