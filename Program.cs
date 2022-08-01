using System;
namespace GamePlayer
{
  class GamePlayer
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("what is the name of the first player?");
      var playerOneName = Console.ReadLine();
      var playerOne = new PlayerOne();
      playerOne.PlayerName = playerOneName;

      Console.WriteLine("what is the name of the second player?");
      var playerTwoName = Console.ReadLine();
      var playerTwo = new PlayerTwo();
      playerTwo.PlayerName = playerTwoName;

      Console.WriteLine(playerOne.PlayerName);
      Console.WriteLine(playerTwo.PlayerName);
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