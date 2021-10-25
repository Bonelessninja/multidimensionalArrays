using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensionalArrays
{
    class Program
    {
       static int maxPlayers = 4;

        static int[] score = new int[maxPlayers];
       static int[] x = new int[maxPlayers];
       static int[] y = new int[maxPlayers];
       static int[] weapon = new int[maxPlayers];

        static void Main(string[] args)
        {
            Console.WriteLine("variables:");
            Console.WriteLine("(RECAP)");
            Console.WriteLine();

           //int score = 0;
           //int x;
           //int y;
           //int weapon;

            Console.WriteLine("single-dimensional Arrays:");
            Console.WriteLine("(RECAP)");
            Console.WriteLine();

            ShowHUD();

            for (int player = 0; player < maxPlayers; player++)
            {
                score[player] = 0;

                weapon[player] = 0;


                x[player] = 0;
                y[player] = 0;
            }
          
            Console.WriteLine("Multidimensional Arrays");
            Console.WriteLine("(will be used to do 2D text-based maps.)");
            Console.WriteLine();

            Console.ReadKey(true);

        }
        static void ShowHUD()
        {
            for (int player = 0; player < maxPlayers; player++)
            {
               Console.WriteLine("player #" + (player + 1) + ":");
                Console.WriteLine("- score:"  + score[player]);
                Console.WriteLine("- weapon:" + weapon[player]);
                Console.WriteLine("- Location: (" + x[player] + "," + y[player] + ")");
                //Console.WriteLine(" score: " + score[player]);
            }
            
        }
    }
}
