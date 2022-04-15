using System;

class Program{
  static void Main(){
    char primeiraLetra = 'L';
    string nome = "Lourenço";
    int num=0;
    Console.WriteLine("Meu nome é: " + nome + "...");
    Console.WriteLine("A primeira letra do meu nome é: " + primeiraLetra);
    Console.WriteLine("Apenas um número aleatório: " + num);
    
//-------------------------------------------------------------------------------

    int num1=100, num2=15, result;

    // num1=100;
    // num2=15;
    result= num1 + num2;

    Console.WriteLine("A soma de "+num1 +" + "+num2+" é igual à: "+result);
    Console.WriteLine("A multiplicação de "+num1 +" com "+num2+" é igual à: "+ num1*num2);
  }
}

// byte n1 = 10;
// int num = -10;
// char letra = 'L';
// float valor = 5.4f;
// string nome = "Lourenço";
// var aux = -15;