using System;

class Aula13 {

  static void Main(){


    // average < 6 = "Reprovado"
    // average < 8 = "Recuperação"
    // average >= 8 = "Aprovado"

    // Nesse caso, é sempre mais fácil fazer as condições dos valores mais baixos para os mais altos. 

    float n1, n2, n3, n4;
    string resultado;

    Console.Write("Digite o valor da primeira nota: ");
    n1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o valor da segunda nota: ");
    n2 = float.Parse(Console.ReadLine());

    Console.Write("Digite o valor da terceira nota: ");
    n3 = float.Parse(Console.ReadLine());

    Console.Write("Digite o valor da quarta nota: ");
    n4 = float.Parse(Console.ReadLine());

    float average = (n1+n2+n3+n4)/4;

    if(average < 6) {
      resultado = "Reprovado";
    } else if (average < 8) {
      resultado = "Recuperação";
    } else {
      resultado = "Aprovado";
    }

    Console.WriteLine("Média de notas: {0}\nSituação: {1}!", average, resultado);
  }
}