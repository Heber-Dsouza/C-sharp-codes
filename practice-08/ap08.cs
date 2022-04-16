using System;

class Aula08 {

  static void Main(){

    int v1, v2, soma;
    string nome;

    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("O seu nome é: {0}", nome);

    Console.WriteLine("-------------------------");
    Console.WriteLine("Calculadora simples:");
    Console.Write("Digite o primeiro número: ");
    v1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    v2 = int.Parse(Console.ReadLine());

    soma = v1 + v2;

    Console.WriteLine("O resultado da operação é: {0}", soma);
  }
}

// Converter string para inteiros:
// int.Parse()
// Convert.ToInt32()