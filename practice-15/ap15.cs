using System;

class Aula15 {

  static void Main(){

    int tempo;
    char choose;

    Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
    Console.Write("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus ");
    choose = char.Parse(Console.ReadLine());

    switch(choose){

      case 'a':
      case 'A':
        tempo=50;
        break;
      case 'c':
      case 'C':
        tempo=500;
        break;
      case 'o':
      case 'O':
        tempo=800;
        break;
      default:
        tempo=-1;
        break;
    }

    if(tempo < 0) {
      Console.WriteLine("Transporte não reconhecido. Digite uma letra válida.");
    } else {
      Console.Write("Para o transporte escolhido o tempo é: {0} minutos", tempo);
    }
  }

}
