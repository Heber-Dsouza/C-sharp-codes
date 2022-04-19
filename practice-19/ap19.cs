using System;

class Aula19{

  static void Main(){

    Console.Clear();

    int[] num = new int[10];

    for(int i=0; i < num.Length; i++){
      // Console.WriteLine("eu sou a linha {0}", i);
      num[i] = (i+1)*5;
      Console.WriteLine("O valor de num da posição {0} é: {1}", i, num[i]);

    }

  }
}