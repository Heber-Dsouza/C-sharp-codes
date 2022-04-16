using System;

class Aula05 {

  static void Main(){

    int num = 10;

    Console.WriteLine(num); //10
    Console.WriteLine(num++); //Ler depois incrementa. 10
    Console.WriteLine(num); //11
    Console.WriteLine(++num); // Incrementa depois ler. 12

    int numX = 25;

    Console.WriteLine("Operações:");
    Console.WriteLine(numX += 10);
    Console.WriteLine(numX -= 10);
    Console.WriteLine(numX *= 10);
    Console.WriteLine(numX /= 10);
    Console.WriteLine(numX %= 10);

    Console.WriteLine("Lógicos:");

    bool a = true;
    bool b = false;

    Console.WriteLine(a & b);
    Console.WriteLine(a & a);
    Console.WriteLine(a | b);
    Console.WriteLine(!a);
    Console.WriteLine(!b);


  }
}

// No C# as operações também são realizadas dentro do Console.Write() e não apenas impressas.
// Javascript: && and -> || or
// C#: & and -> | or