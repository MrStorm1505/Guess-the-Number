using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Welcome to Guess the Number!");
        //Defininf the number to be guessed
        Random random = new Random();
        int secretNumber = random.Next(1, 101); //Returns a number between 1 and 100

        Console.WriteLine("I'm thinking in a number between 1 and 100");

        for (int i = 0; i < 5; i++)
        {
            //Requesting the number to the player
            Console.WriteLine("Enter your guess: ");
            string input = Console.ReadLine();
            int guess = int.Parse(input) ;

            //Game logic
            if (guess > secretNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low...");
            }
            else
            {
                Console.WriteLine("That's right! You Won! 🏆");
                return; //This instruction ends the game
            }
        }
        Console.WriteLine("Game Over");
    }
}