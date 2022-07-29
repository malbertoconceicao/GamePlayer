using System;
namespace GamePlayer
{
  class Player
  {
    public Player(string player)
    {
      LifeStatus = 100;
      PlayerName = player;
    }
    public int LifeStatus { get; set; }
    public string PlayerName { get; set; }
  }
}