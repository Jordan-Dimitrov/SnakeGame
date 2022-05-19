using System;

namespace SnakeGame
{
    class Program
    {
        public static void Main()
        {
            Random rndX = new Random();
            Random rndY = new Random();

            int appleX = rndX.Next(11, Console.WindowWidth);
            int appleY = rndY.Next(11, Console.WindowHeight);

            int playerX = 10;
            int playerY = 10;

            int countReset = 1;
            bool cond = true;
            int score = 0;

            while (true)
            {
                if (appleX == playerX && appleY == playerY)
                {
                    cond = false;
                    score++;
                }
                if (cond == false)
                {
                    appleX = rndX.Next(11, 20);
                    appleY = rndY.Next(11, 20);
                    cond = true;
                }

                ConsoleKeyInfo input = Console.ReadKey();
                Console.SetCursorPosition(1, 1);
                Console.WriteLine(input.Key);
                Console.Clear();

                if (input.Key == ConsoleKey.W)
                {
                    playerY--;
                    countReset++;
                }
                else if (input.Key == ConsoleKey.S)
                {
                    playerY++;
                    countReset++;
                }

                if (input.Key == ConsoleKey.A)
                {
                    playerX--;
                    countReset++;
                }
                else if (input.Key == ConsoleKey.D)
                {
                    playerX++;
                    countReset++;
                }

                playerX = Math.Max(playerX, 0);
                playerX = Math.Min(playerX, Console.BufferWidth - 1);
                playerY = Math.Max(playerY, 0);
                playerY = Math.Min(playerY, Console.BufferHeight - 1);

                Console.SetCursorPosition(playerX, playerY);
                Console.WriteLine("#");
                Console.SetCursorPosition(appleX, appleY);
                Console.WriteLine("@");
                Console.SetCursorPosition(40, 40);
                Console.WriteLine(score);
            }
        }
    }
}