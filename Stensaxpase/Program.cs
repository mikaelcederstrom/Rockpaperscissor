using System;

namespace Stensaxpase
{
    class Program
    {
        static int scorePlayer1;
        static int scorePlayer2;
        
        static void Main(string[] args)
        {
            StartingGame();
            PlayingGame();
            EndingGame();
        }

        static void StartingGame()
        {
            Console.WriteLine("Ett spel av sten, sax, påse. Först till fem som gäller");
            Console.WriteLine(@"Välj mellan sten, sax och påse genom att skriva den tillhörande siffran");
            Console.WriteLine("1. Sten");
            Console.WriteLine("2. Sax");
            Console.WriteLine("3. Påse");
        }

        static void PlayingGame()
        {
            Random rnd = new Random();
            int player1Move = Convert.ToInt32(Console.ReadLine());

            while (scorePlayer1 < 5 && scorePlayer2 < 5)
            {
                int player2Move = rnd.Next(1, 4);
                OutputMove(player1Move, "Du");
                OutputMove(player2Move, "Datorn");
               
                    if (player1Move == player2Move)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Det blev lika");
                        Console.ResetColor();
                    }

                    else if ((player1Move == 1 && player2Move == 2) || (player1Move == 2 && player2Move == 3) ||
                             (player1Move == 3 && player2Move == 1))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Du vann");
                        scorePlayer1++;
                        Console.ResetColor();
                    }

                    else if ((player1Move == 1 && player2Move == 3) || (player1Move == 2 && player2Move == 1) ||
                             (player1Move == 3 && player2Move == 2))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Du förlorade");
                        scorePlayer2++;
                        Console.ResetColor();
                    }
                    
                    Console.WriteLine($"Du har {scorePlayer1} poäng & datorn har {scorePlayer2} poäng");
                    Console.WriteLine();
                    if (scorePlayer1 < 5 && scorePlayer2 < 5)
                    {
                    Console.WriteLine("Välj ett nummer på nytt");
                    player1Move = Convert.ToInt32(Console.ReadLine());
                    }
                    
            }
        }

        static void OutputMove(int move, string name)
        {
            if (move == 1)
            {
                Console.WriteLine($"{name} valde sten");
            }
            else if (move == 2)
            {
                Console.WriteLine($"{name} valde sax");
            }
            else if (move == 3)
            {
                Console.WriteLine($"{name} valde påse");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Det är ett ogiligt val");
                Console.ResetColor();
            }
            
        }

        static void EndingGame()
        {
            if (scorePlayer1 > scorePlayer2)
            {
                Console.WriteLine($"Du vinner med {scorePlayer1} poäng emot datorns {scorePlayer2} poäng");
            }
            else
            {
                Console.WriteLine($"Datorn vinner med {scorePlayer2} poäng emot dina {scorePlayer1} poäng");
            }

            Console.WriteLine("Om du vill spela igen trycker du y");
            string playAgain = Console.ReadLine();
            if (playAgain == "y")
            {
               Console.WriteLine();
               scorePlayer1 = 0;
               scorePlayer2 = 0;
               Main(null);
            }

        }
    
    }
}
