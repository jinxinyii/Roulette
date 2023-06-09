using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        RouletteApp();
    }

    static void RouletteApp()
    {
        Console.WriteLine("ROULETTE!");

        List<string> playerNames = new List<string>();

        bool addPlayer = true;

        while (addPlayer)
        {
            Console.Write("Enter player name (or 'done' if no more players): ");
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "done")
            {
                addPlayer = false;
            }
            else
            {
                playerNames.Add(playerName);
            }
        }

        Console.WriteLine("\nLET'S PLAY ROULETTE!");

        Random random = new Random();

        foreach (string playerName in playerNames)
        {
            Console.WriteLine($"\n{playerName}, it's your turn to roll the roulette.");
            Console.WriteLine("Press Enter to spin the roulette...");
            Console.ReadLine();

            int randomNumber = random.Next(95, 100);
            Console.WriteLine($"The arrow lands on number {randomNumber}!");
        }

        Console.WriteLine("\nBYE!");
    }
}
