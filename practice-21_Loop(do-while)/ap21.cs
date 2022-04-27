using System;

class Aula21{

  static void Main(){

    string senha = "123";
    string senhaUser = "";

    int tentativas = 0;

    do{

      Console.Clear();

      if(tentativas > 0){
        Console.WriteLine("Senha incorreta, número de tentativas: {0}", tentativas);
      }

      Console.Write("Digite sua senha: ");
      senhaUser = Console.ReadLine();
      tentativas++;
    }while(senha != senhaUser & tentativas <= 3);

    if(tentativas > 3){
      
      Console.WriteLine("Número de tentativas atingidas. Login bloqueado...");
    } else {

      Console.WriteLine("Senha correta...");
    }

  }
}