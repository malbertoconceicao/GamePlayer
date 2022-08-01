using System;
namespace GamePlayer
{
  class GamePlayer
  {
    static void Main(string[] args)
    {
      var player = new PlayerOne();
      Console.Clear();
      Console.WriteLine("Olá {0} ", Environment.UserName);
      Thread.Sleep(3000);

      Random dados = new Random();

      for (int i = 0; i < 4; i++)
      {
        Console.Clear();
        Console.WriteLine("Dados rolando");
        Console.WriteLine(dados.Next(0, 10));
        Thread.Sleep(1000);
      }
      Console.Clear();
      Console.WriteLine("Dados parados");
      Console.WriteLine(dados.Next(0, 10));
    }
  }
}