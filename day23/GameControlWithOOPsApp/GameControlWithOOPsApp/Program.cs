
using GameControlWithOOPsApp.Models;

namespace GameControlWithOOPsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Number Guess Game");
                Console.WriteLine("------------------");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();
                //int input = Convert.ToInt32(Console.ReadLine());

                //switch (option)
                //{
                //    case "1":
                //        PlayNumberGuessGame();
                //        break;
                //    case "2":
                //        playAgain = false;
                //        Console.WriteLine("Goodbye!");
                //        break;
                //    default:
                //        Console.WriteLine("Invalid option. Please choose again.");
                //        break;
                //}


                if (option == "1")
                {
                    PlayNumberGuessGame();
                }
                else if (option == "2")
                {
                    playAgain = false;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose again.");
                }
            }
        }

        private static void PlayNumberGuessGame()
        {
            GameControl game = new GameControl();
            game.InitializeGame(3);
            game.Play();
            game.AskToPlayAgain();
        }
    }
}
