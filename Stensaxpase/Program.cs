using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Stensaxpase
{
    class Program
    {
        static int scorePlayer1;
        static int scoreplayer2;
        
        static void Main(string[] args)
        {

            
            string player1;
            Random rnd = new Random();
            Console.WriteLine("Välj mellan sten, sax och påse genom att skriva den tillhörande siffran");
            Console.WriteLine("1. Sten");
            Console.WriteLine("2. Sax");
            Console.WriteLine("3. Påse");
            player1 = Console.ReadLine();



            while (true)
            {


                var x = Convert.ToInt32(player1);

                if (x == 1)
                {

                    Console.WriteLine("Du valde sten");
                }
                else if (x == 2)
                {

                    Console.WriteLine("Du valde sax");

                }
                else if (x == 3)
                {
                    Console.WriteLine("Du valde påse");
                }
                else
                {
                    Console.WriteLine("Det är ett ogiligt val");
                }

                int player2 = rnd.Next(1, 4);


                if (player2 == 1)
                {
                    Console.WriteLine("Datorn valde sten");
                }
                else if (player2 == 2)
                {
                    Console.WriteLine("Datorn valde sax");
                }
                else if (player2 == 3)
                {
                    Console.WriteLine("Datorn valde påse");
                }

                if (x == player2)
                {
                    Console.WriteLine("Det blev lika");
                }


                else if (x == 1 && player2 == 2)
                {
                    Console.WriteLine("Du vann");
                    scorePlayer1++;
                   
                }

                else if (x == 1 && player2 == 3)
                {
                    Console.WriteLine("Du förlorade");
                    scoreplayer2++;
                }

                else if (x == 2 && player2 == 3)
                {
                    Console.WriteLine("Du vann");
                    scorePlayer1++;
                }

                else if (x == 2 && player2 == 1)
                {
                    Console.WriteLine("Du förlorade");
                    scoreplayer2++;
                }

                else if (x == 3 && player2 == 1)
                {
                    Console.WriteLine("Du vann");
                    scorePlayer1++;
                }

                else if (x == 3 && player2 == 2)
                {
                    Console.WriteLine("Du förlorade");
                    scoreplayer2++;
                }

                Console.WriteLine($"Du har {scorePlayer1} poäng & datorn har {scoreplayer2} poäng");
                Console.WriteLine("Välj ett nytt nummer för att spela igen");
                player1 = Console.ReadLine();
            }

            Console.ReadKey();

        }
    }
}
