using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    internal class Game_Manager
    {
        //legfelső betű koordináta sor
        public static char[] Letter_Fields = { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        //Játékos mezői
        public static char[,] battlefield_Player = new char[,] {{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },
                {'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },
                {'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', } };
        //Ellenfél mezői (Rejtve/nem látható)
        public static char[,] battlefield_CPU = new char[,] {{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },
                {'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },
                {'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', } };
        //Ellenfél mezői (Látható)
        public static char[,] battlefield_CPU_Show = new char[,] {{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },
                {'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },
                {'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', },{'~','~','~','~','~','~','~','~','~','~', } };
        public static bool end_Game = false;

        private static int ship_Nums = 17;
        public static bool menu_Change = true;
        //Választott koordináta átalakítása
        public static Dictionary<char, int> letter_Space_ToIndex = new Dictionary<char, int>()
        {
            {'A', 0},
            {'B', 1},
            {'C', 2},
            {'D', 3},
            {'E', 4},
            {'F', 5},
            {'G', 6},
            {'H', 7},
            {'I', 8},
            {'J', 9}
        };
        public static void Game_Manager_Operator(int player_Num)
        {
            do
            {
                Main_Menu.Print_Menu(menu_Change);
            }
            while (menu_Change);
            if (Main_Menu.selectes_Menu == 0)
            {
                
                Welcome_Words.Print_Welcome();
                Welcome_Words.Battle_Start_Counter();
                do
                {
                    Console.WriteLine("Player Fields");
                    Battlefield_Printer.Print_BattleField(Letter_Fields, battlefield_Player);
                    Console.WriteLine();
                    Console.WriteLine("CPU/Player 2 Fields");
                    Battlefield_Printer.Print_BattleField_Visible(Letter_Fields, battlefield_CPU);



                    if (player_Num == 1)
                    {
                        if (Game_Manager.end_Game == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("BATTLE END");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            break;
                        }
                        Console.WriteLine("Player 1 Turn");
                        Input_Operator.Get_Input_PlayerOne();
                        player_Num = 2;
                    }
                    else if (player_Num == 2)
                    {
                        if (Game_Manager.end_Game == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("BATTLE END");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            break;
                        }
                        Console.WriteLine("Player 2 Turn");
                        Input_Operator.Get_Input_PlayerTwo();
                        player_Num = 1;
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                while (!end_Game);
            }
            else
            {
                Console.WriteLine("Good Bye.");
            }
        }

        public static void Random_Battlefield_Generator(char[,] battlefield)
        {
            int counter = 0;
            Random rnd = new Random();

            List<int> random_PlacesX = new List<int>();
            List<int> random_PlacesY = new List<int>();

            for (int i = 0; i < ship_Nums + 1; i++)
            {
                random_PlacesX.Add(rnd.Next(0, 10));
                random_PlacesY.Add(rnd.Next(0, 10));
                counter++;
            }

            for (int i = 0; i < ship_Nums; i++)
            {
                battlefield[random_PlacesX[i], random_PlacesY[i]] = 'S';

            }
        }
    }
}
