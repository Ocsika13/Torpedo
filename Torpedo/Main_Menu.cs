using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    public enum menus { Play, Quit };

    internal class Main_Menu
    {
        
        static int Main_Menu_Index = 0;
        public static int selectes_Menu;
        public static void Print_Menu(bool menu_Change)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == Main_Menu_Index)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(((menus)i).ToString().PadLeft(5));
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(((menus)i).ToString().PadLeft(5));
                }
                
            }
            Menu_Controller();
            Console.Clear();
        }
        public static void Menu_Controller()
        {
            ConsoleKey ck = Console.ReadKey().Key;
            switch (ck)
            {
                case ConsoleKey.UpArrow:
                    if (Main_Menu_Index-- == -1)
                    {
                        Main_Menu_Index = 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Main_Menu_Index++ == 2)
                    {
                        Main_Menu_Index = 0;
                    }
                    break;
                case ConsoleKey.Enter:
                    Game_Manager.menu_Change = false;
                    selectes_Menu = Main_Menu_Index;
                    break;

            }
        }


    }
}
