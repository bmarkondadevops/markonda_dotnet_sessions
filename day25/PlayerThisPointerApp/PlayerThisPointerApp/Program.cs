using PlayerThisPointerApp.Model;
using System;

class Program
{

    static void Main()
    {
       
        var playerMinu = new Player(1, "Minu", 18);
        PrintDetails(playerMinu);


        var playerVenkat = new Player(2, "Venkat");
        PrintDetails(playerVenkat);

        Player elder =playerVenkat.WhoIsElder(playerMinu);
        //PrintDetails(elder);       

    }

    private static void PrintDetails(Player player)
    {
        Console.WriteLine($"Player ID: {player.Id}");
        Console.WriteLine($"Player Name: {(player.Name==null? "Null": player.Name)}");
        Console.WriteLine($"Player Age: {player.Age}");
        Console.WriteLine($"hascoe is {player.GetHashCode()}");
        Console.WriteLine();

    }
}