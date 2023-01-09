using System;

namespace GuessTheNumber_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int hiddenNumber = rnd.Next(0, 100);
            int attempts = 0;
            int lives = 10;
            int bonusNumber = 1000;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Guess the number: ");
                int guessedNumber = int.Parse(Console.ReadLine());
                attempts++;

                if (guessedNumber == bonusNumber)
                {
                    Console.WriteLine("you hit the bonus number, you received 3 extra lives");
                    lives += 3;
                }

                if (hiddenNumber < guessedNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("less");
                    lives--;
                }
                else if (hiddenNumber > guessedNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("more");
                    lives--;
                }
                else if (hiddenNumber == guessedNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations, you guessed the number! you used {attempts} attempts");
                    break;
                }

                if (lives == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Game over loser!");
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("press any key to close the program.");
            Console.ReadKey();
        }
    }
}
