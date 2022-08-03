using System;
namespace GamePlayer
{
  class Menus
  {
    public static void MenuPrincipal()
    {
      Console.WriteLine("Bem vindo {0}", Environment.UserName);
      Console.WriteLine("Escolha uma das opçoes abaixo.");
      Console.WriteLine("1 - Jogar");
      Console.WriteLine("2 - Regras do Jogo");
      Console.WriteLine("3 - Sair");
      var opcao = Console.ReadLine();
    }
  }
}