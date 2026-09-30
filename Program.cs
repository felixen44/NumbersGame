// Felix BUV26
// Lab 4 - Guess the Number
// A small game where the computer thinks of a secret number that the player has to guess.

using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // The welcome message shown when the game starts.
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            // Creates a random number generator.
            Random random = new Random();

            // Draws the secret number. Next(1, 21) gives a number between 1 and 20,
            // because 21 is the upper bound and is not included.
            int secretNumber = random.Next(1, 21);

            // Counter that keeps track of how many guesses the player has made.
            int guessCount = 0;

            // Keeps track of whether the player has guessed correctly. Initially the answer is no.
            bool guessedCorrectly = false;

            // The loop runs as long as the player has attempts left (max 5) and has not guessed correctly.
            while (guessCount < 5 && guessedCorrectly == false)
            {
                // Reads the player's guess and converts it from text to an integer.
                int guess = int.Parse(Console.ReadLine());

                // The player has now used one of their guesses.
                guessCount = guessCount + 1;

                // Sends the guess to the CheckGuess method and stores the answer (true or false).
                guessedCorrectly = CheckGuess(guess, secretNumber);
            }

            // If the player never guessed correctly within the five attempts, this is printed.
            if (guessedCorrectly == false)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }
        }

        // Custom method that compares the guess with the secret number.
        // It prints a hint and returns true if the guess was correct.
        static bool CheckGuess(int guess, int secretNumber)
        {
            if (guess == secretNumber)
            {
                // Correct guess.
                Console.WriteLine("Wohoo! Du gjorde det!");
                return true;
            }
            else if (guess < secretNumber)
            {
                // Guess too low.
                Console.WriteLine("Tyvärr du gissade för lågt!");
                return false;
            }
            else
            {
                // Here the guess is too high, because the other two cases are already checked.
                Console.WriteLine("Tyvärr du gissade för högt!");
                return false;
            }
        }
    }
}
