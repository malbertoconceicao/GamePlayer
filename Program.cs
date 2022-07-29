using System;
namespace GamePlayer
{
  class GamePlayer
  {
    static void Main(string[] args)
    {
      Console.WriteLine("what is the name of the first player?");
      var playerOneName = Console.ReadLine();

      var playerOne = new Player(playerOneName);
    }
  }
}