using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            string guessStr;
            bool correctAnswer = false;

            while(correctAnswer == false) {
                guessStr = Console.ReadLine();
                if(guessStr == "-1") {
                    Console.WriteLine("You gave up!");
                    break;
                }
                if(int.TryParse(guessStr, out int guess)) {
                    if(guess == theNumber) {
                        Console.WriteLine("You guessed it!");
                        correctAnswer = true;
                    }
                    else if(guess < theNumber) {
                        Console.WriteLine("Too low!");
                    }
                    else {
                        Console.WriteLine("Too high!");
                    }
                }
                else {
                    Console.WriteLine("Invalid input!");
                }
            }

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            
        }
    }
}
