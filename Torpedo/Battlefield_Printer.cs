using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    internal class Battlefield_Printer
    {
        public static int needed_Ship_Num;

        //Csatamezőt kiíró metódus
        public static void Print_BattleField(char[] letter_Fields, char[,] battlefield)
        {
            bool end_Game = false;
            int counter = 0;
            for (int i = 0; i < letter_Fields.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(letter_Fields[i].ToString() + ' ');
            }
            Console.WriteLine();

            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i);
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (battlefield[i, j] == 'X')
                    {
                        counter++;
                    }
                    Console.Write(' ' + battlefield[i, j].ToString());
                }
                Console.WriteLine();

            }
            if (counter == needed_Ship_Num)
            {
                
                Game_Manager.end_Game = true;
                Console.ForegroundColor= ConsoleColor.Red;

            }
            else
            {
                counter = 0;
            }
            Console.ForegroundColor = ConsoleColor.White;


        }
        public static void Print_BattleField_Visible(char[] letter_Fields, char[,] battlefield)
        {
            bool end_Game = false;
            int counter = 0;
            for (int i = 0; i < letter_Fields.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(letter_Fields[i].ToString() + ' ');
            }
            Console.WriteLine();

            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i);
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (battlefield[i, j] == 'X')
                    {
                        counter++;
                    }
                    if (battlefield[i,j] == 'S')
                    {
                        Console.Write(" ~");
                    }
                    else if(battlefield[i, j] == 'X')
                    {
                        Console.Write(" X");
                    }
                    else if(battlefield[i, j] == 'O')
                    {
                        Console.Write(" O");
                    }
                    else
                    {
                        Console.Write(" ~");
                    }
                }
                Console.WriteLine();

            }
            if (counter == needed_Ship_Num)
            {

                Game_Manager.end_Game = true;
                Console.ForegroundColor = ConsoleColor.Red;

            }
            else
            {
                counter = 0;
            }
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
