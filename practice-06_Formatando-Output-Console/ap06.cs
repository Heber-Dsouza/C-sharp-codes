using System;

class Aula06 {

  static void Main(){

    string name = "Lourenço";

    int idade = 26;

    Console.WriteLine("Olá {0}!\nvocê tem {1} anos?", name, idade);

    Console.Write("\n\n\n");

    double valorCompra = 5.50;
    double valorVenda;
    double lucro = 0.1;
    string produto = "Pastel de Queijo";

    valorVenda = valorCompra + (valorCompra * lucro);

    Console.WriteLine("Produto..........:{0, 18}", produto);
    Console.WriteLine("Valor de Compra..:{0,18:c}", valorCompra);
    Console.WriteLine("Lucro............:{0,18:p}", lucro);
    Console.WriteLine("Valor de Venda...:{0,18:c}", valorVenda);
    Console.WriteLine();

  }
}

// \n = "Enter"
// \t = "Tab"