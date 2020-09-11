using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using TextAdventure;

public class Program
{
    public static Player currentPlayer = new Player();
    static void Main(string[] args)
    {
        Game _game = new Game();
        _game.GameInitialize();
    }

}
