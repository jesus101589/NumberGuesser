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

            Console.WriteLine("Guess a number between 1 and 10");


        }
    }
}
