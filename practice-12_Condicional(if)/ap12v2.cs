using System;

class Aula12 {

  static void Main() {

    float n1, n2, n3;
    string resultado = "Reprovado";

    Console.Write("Digite o valor da sua primeira nota: ");
    n1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o valor da sua segunda nota: ");
    n2 = float.Parse(Console.ReadLine());

    Console.Write("Digite o valor da sua terceira nota: ");
    n3 = float.Parse(Console.ReadLine());

    float media = ((n1 + n2 + n3)/3);

    if(media >= 7) {
      resultado = "Aprovado";
    }

      Console.WriteLine("Media final: {0}\nSituação: {1}!", media, resultado);

    
  }
}