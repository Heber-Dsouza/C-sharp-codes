using System;

class Aula17{

  static void Main(){

    int[] numeros = new int[5];
    string[] nomes = new string[4]{"Lourenço", "João", "Ana", "Catarina"}; // Ou simplesmente string[] nomes = {"Lourenço", "João", "Ana"}
    char[] letras = {'L', 'O', 'U', 'R', 'E', 'N', 'Ç', 'O'};

    numeros[0] = 11;
    numeros[1] = 22;
    numeros[2] = 33;
    numeros[3] = 44;
    numeros[4] = 55;

    Console.Clear();
    Console.WriteLine(numeros[2]);
    Console.WriteLine(nomes[3]);
    Console.WriteLine(letras[3]);
  }
}