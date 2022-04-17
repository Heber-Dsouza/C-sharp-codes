using System;

class Aula12 {

  static void Main(){

    Console.Write("Qual a sua idade? ");
    int idade = int.Parse(Console.ReadLine());

    if(idade >= 18) {
      Console.WriteLine("Vc é maior de idade.");
    } else {
      Console.WriteLine("Vc é menor de idade.");
    }
    
  }
}