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
    }
  }
}