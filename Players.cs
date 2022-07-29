using System;
namespace GamePlayer
{
  interface Player
  {
    public int LifeStatus { get; set; }
    public string PlayerName { get; set; }
  }
  class PlayerOne : Player
  {
    public int LifeStatus { get; set; }
    public string PlayerName { get; set; }
  }
  class PlayerTwo : Player
  {
    public int LifeStatus { get; set; }
    public string PlayerName { get; set; }
  }
}