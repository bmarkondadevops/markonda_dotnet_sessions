
namespace GameControlApp
{
    internal class Program
    {
        static void Main()
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Welcome to Number Guess Game!!!!");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Exit");
                Console.Write("Please Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        PlayGame();
                        break;
                    case "2":
                        playAgain = false;
                        Console.WriteLine("Goodbye! Thank you for play the Game!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        private static void PlayGame()
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            Console.WriteLine("Guess number is: " + numberToGuess);

            int attempts = 0;
            const int maxAttempts = 3;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine($"You have {maxAttempts} attempts to guess it.");

            while (attempts < maxAttempts)
            {
                Console.Write($"Attempt {attempts + 1}: Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    attempts++;

                    if (guess < numberToGuess)
                    {
                        Console.WriteLine("Too low Try again.");
                    }
                    else if (guess > numberToGuess)
                    {
                        Console.WriteLine("Too high Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations You found the number in {attempts} attempt.");
                        return; // Exit the method after winning
                    }

                    if (attempts == maxAttempts)
                    {
                        Console.WriteLine($"Sorry, you've used up all your attempts. The number was {numberToGuess}.");
                        return; // Exit the method after losing
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    // Do not increment attempts for invalid inputs
                }
            }
        }
    }
}
