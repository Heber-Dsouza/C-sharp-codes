using System;

class Aula10 {
    enum DiasDaSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

  static void Main(){

    DiasDaSemana feriado = DiasDaSemana.Domingo;
    DiasDaSemana folga = (DiasDaSemana)1; // Com cast

    int trabalho = (int)DiasDaSemana.Quinta; // Associar ao índice

    Console.WriteLine(feriado);
    Console.WriteLine(folga);
    Console.WriteLine(trabalho);
  }
}