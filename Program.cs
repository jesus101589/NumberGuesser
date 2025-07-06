using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    internal class Program
    {
        // Entry Point of the Application (Method)
        static void Main(string[] args)
        {
            // Set app variables 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jesus Salinas";

            // Change the text console color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out the app information
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset the text console color
            Console.ResetColor();

            // Ask for user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);

            // INITIALIZE CORRECT NUMBER
            int correctNumber = 7;

            // INITIALIZE GUESS VARIABLE
            int guess = 0;

            // Ask user to guess a number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not equal to correct number
            while (guess != correctNumber)
            {
                // Get user input
                string input = Console.ReadLine();

                // Try to parse the input to an integer
                guess = Int32.Parse(input);

                // Match the guess to the correct number
                if (guess != correctNumber)
                {
                    // Change the text console color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Write out the message
                    Console.WriteLine("Wrong number, try again!");

                    // Reset the text console color
                    Console.ResetColor();
                }
            }

            // Change the text console color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Write out the message..Tell the user they guessed the correct number
            Console.WriteLine("Congratulations {0}, you guessed the correct number!", inputName);

            // Reset the text console color
            Console.ResetColor();
        }
    }
}
