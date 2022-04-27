using System;

class Aula20{

  static void Main(){

    int cont = 0;
    int[] num = new int[20];

  Console.Clear();
  Console.WriteLine("Aqui começa...");

    while(cont < num.Length){

      num[cont] = cont;
      Console.WriteLine(num[cont]);
      cont++;
    }
  }
}