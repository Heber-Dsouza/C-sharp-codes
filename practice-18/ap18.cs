using System;

class Aula18{

  static void Main(){

    int[,] num = new int[3,5];
    int[,] numX = new int[2,2]{{10,20},{30,40}};

    // 10 20 30 40 50
    // 15 25 35 45 55
    // 12 22 32 42 52

    num[0,0] = 10;
    num[0,1] = 20;
    num[0,2] = 30;
    num[0,3] = 40;
    num[0,4] = 50;

    num[1,0] = 15;
    num[1,1] = 25;
    num[1,2] = 35;
    num[1,3] = 45;
    num[1,4] = 55;

    num[2,0] = 12;
    num[2,1] = 22;
    num[2,2] = 32;
    num[2,3] = 42;
    num[2,4] = 52;

    Console.Clear();
    Console.WriteLine(num[0, 4]);
    Console.WriteLine(numX[1, 1]);

  }
}