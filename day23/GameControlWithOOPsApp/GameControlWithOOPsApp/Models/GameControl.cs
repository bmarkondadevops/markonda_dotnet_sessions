using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlWithOOPsApp.Models
{
    internal class GameControl
    {
        private int _numberToGuess;
        private int _maxAttempts;
        private int _attempts;
        private bool _gameOver;

        public int NumberToGuess
        {
            get { return _numberToGuess; }
            set { _numberToGuess = value; }
        }

        public int MaxAttempts
        {
            get { return _maxAttempts; }
            set { _maxAttempts = value; }
        }

        public int Attempts
        {
            get { return _attempts; }
            set { _attempts = value; }
        }

        public bool IsGameOver
        {
            get { return _gameOver; }
            set { _gameOver = value; }
        }

        public void InitializeGame(int maxAttempts)
        {
            Random random = new Random();
            NumberToGuess = random.Next(1, 101);
            MaxAttempts = maxAttempts;
            Attempts = 0;
            IsGameOver = false;
        }

       

        //Method to play the Game
        public void Play()
        {
            Console.WriteLine("The guess number between 1 and 100 only.");            

            while (!IsGameOver && Attempts < MaxAttempts)
            {
                Console.Write($"Attempt {Attempts + 1}: Enter your guess: ");
                //Console.WriteLine($"The guess number is:: {NumberToGuess}");

                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    Attempts++;

                    if (guess < NumberToGuess)
                    {
                        Console.WriteLine("Too low Try again.");
                    }
                    else if (guess > NumberToGuess)
                    {
                        Console.WriteLine("Too high Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations You found the number in {Attempts} attempts.");
                        IsGameOver = true;
                    }

                    if (Attempts == MaxAttempts && !IsGameOver)
                    {
                        Console.WriteLine($"Sorry, you've used up all your attempts. The number was {NumberToGuess}.");
                        IsGameOver = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    // Do not increment attempts for invalid inputs
                }
            }
        }
        // Method to ask if the user wants to play again
        public void AskToPlayAgain()
        {
            Console.Write("Do you want to play again? (1/2): ");
            int response = Convert.ToInt32(Console.ReadLine());

            while (response != 1 && response != 2)
            {
                Console.Write("Invalid input. Please enter numbers '1' or '2': ");
                response = Convert.ToInt32(Console.ReadLine());
            }

            if (response == 2)
            {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0); // Exit the program if user chooses not to play again
            }
            else
            {
                ResetGame();
            }
        }

        // Method to reset the game state for a new game
        private void ResetGame()
        {
            Random random = new Random();
            NumberToGuess = random.Next(1, 101);
            Attempts = 0;
            IsGameOver = false;
        }


    }
}



