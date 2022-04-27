using System;

class randomFunction{

  static void Main(){

    int[] vetor = new int[5];

    Random random = new Random();

    //------------------------------------------------------------------------------

    Console.Clear();

    for (int i = 0; i < vetor.Length; i++)
    {
      vetor[i] = random.Next(50); // -> retorna um valor máximo
      // vector1[i]=random.Next(); -> retorna um valor inteiro qualquer
      // vector1[i]=random.Next(50, 100); -> retorna um valor mínimo e máximo
    }
    Console.WriteLine("Elementos do vetor1:");
    foreach (int n in vetor)
    {

      Console.WriteLine(n);
    }
    
    Console.WriteLine("----------------------------------------------------");

  }
}