using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            bool play = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string userResponse;

            while(play)
            {
                guess = 0;
                guesses = 0;
                userResponse = "";
                number = randNum.Next(min, max + 1);

                while(guess != number)
                {
                    Console.WriteLine("I'm thinking of a number between 1 and 100. Give it a shot and take a guess!");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You guessed: " + guess);

                    if(guess > number)
                    {
                        Console.WriteLine("Your guess is too high! Try again with a lower number!");
                    }
                    else if(guess < number)
                    {
                        Console.WriteLine("Your guess is too low! Try again with a higher number!");
                    }
                    guesses++;
                }
                Console.WriteLine("You got it! The number was " + number + " and it took you " + guesses + " guesses to get it. You Win!");

                Console.WriteLine("Do you wanna play again? (Y/N): ");
                userResponse = Console.ReadLine();
                userResponse = userResponse.ToUpper();

                if(userResponse == "Y")
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}
