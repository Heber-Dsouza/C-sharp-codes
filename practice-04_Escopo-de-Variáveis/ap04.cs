using System;

class Aula04 {

  static int numGlobal = 15;
  static void Main(){
    int num1=10;
    Console.WriteLine(numGlobal);
    Console.WriteLine(num1);
  }

  void teste(){
    int num2=5;

    Console.Write(numGlobal);
  }
}