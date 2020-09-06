using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Homework8;

namespace Homework8ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayer Winner = new OrdinaryPlayer("");
            int NumberOfPlayers;
            int Weight = new Random().Next(40, 141);
            int NumberOfTries = 0;
            int ClosestGuessedNumber = 0;
            List<int> TriedNumbers = new List<int>();
            List<BasePlayer> players = new List<BasePlayer>();
            
            Console.WriteLine("Enter the number of players(from 2 to 8)");
            NumberOfPlayers = int.Parse(Console.ReadLine());
                
            for(int i = 0; i < NumberOfPlayers; i++)
            {
                Console.WriteLine("Press 1 to add an ordinary player, 2 - player notepad, 3 - uber player, 4 - cheater, 5 - uber cheater");
                string PlayerType = Console.ReadLine();
                Console.WriteLine("Enter player's name");
                string name = Console.ReadLine();
                switch (PlayerType)
                {
                    case "1":
                        players.Add(new OrdinaryPlayer(name));
                        break;
                    case "2":
                        players.Add(new PlayerNotepad(name));
                        break;
                    case "3":
                        players.Add(new UberPlayer(name));
                        break;
                    case "4":
                        players.Add(new CheaterPlayer(name, TriedNumbers));
                        break;
                    case "5":
                        players.Add(new UberCheaterPlayer(name, TriedNumbers));
                        break;
                }
            }

            bool flag = true;
            int result;
            while(flag)
            {
                foreach (var player in players)
                {
                    result = player.GuessTheWeight();

                    if (!TriedNumbers.Contains(result))
                    {
                        TriedNumbers.Add(result);
                    }
                    if(ClosestGuessedNumber == 0)
                    {
                        ClosestGuessedNumber = result;
                    }
                    else
                    {
                        if(Math.Abs(Weight - result) < Math.Abs(Weight - ClosestGuessedNumber))
                        {
                            ClosestGuessedNumber = result;
                            Winner = player;
                        }
                    }
                    if (result == Weight || NumberOfTries == 100)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            Console.WriteLine(Winner.Name);

            Console.ReadKey();
        }
    }
}
