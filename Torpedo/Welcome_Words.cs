using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    //Üdvözlő Üzenetek
    internal class Welcome_Words
    {
        //Játék indulásnál köszöntő üzenet
        public static void Print_Welcome()
        {
            //Játék köszöntő + név megadása
            Console.Title = "Torpedo";

            Console.WriteLine(" HELLO IN TORPEDO BATTLE");
            Console.WriteLine("How many ship you want to find for End Game (between: 1-16)");
            string needed_Ship_Num = Console.ReadLine();
            Battlefield_Printer.needed_Ship_Num = int.Parse(needed_Ship_Num);
            Thread.Sleep(2000);
            Console.Clear();
        }
        //játék indulásáig vissza számoló
        public static void Battle_Start_Counter()
        {
            int start_Battle_Counter = 3;
            //Játék előtti számolás móka kijelzés
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Battle Start in: " + start_Battle_Counter);
                start_Battle_Counter--;
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
