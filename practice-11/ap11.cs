using System;

class Aula11 {

  static void Main(){

    int n1 = 10;
    float n2 = n1;

    Console.WriteLine(n2);

    // Conversão segura (ou implícita). Será convertido altomáticamente.

    float x = 5.56f;
    int y = (int)x; // Operação de Type Cast. (Conversão explícita).

    Console.WriteLine(y);
  }
}