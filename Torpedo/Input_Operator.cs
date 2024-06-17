using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    internal class Input_Operator
    {
        public static string user_Input;
        public static void Get_Input_PlayerOne()
        {
        back:
            Console.WriteLine("Please give a coordinate");
            user_Input = Console.ReadLine().ToUpper();
            //Bevitt karaktrehossz elemzése
            while (user_Input.Length != 2)
            {
                Console.WriteLine("Not knowning coordinate try again");
                user_Input = Console.ReadLine().ToUpper();

            }
            Console.WriteLine("Coordinate lenght is good");
            Console.WriteLine("Input is: " + user_Input);

            char[] inputs = user_Input.ToCharArray();
            //koordináta elemzése, hogy egy betű és egy szám legyen
            if (!char.IsNumber(inputs[1]) || !char.IsAsciiLetter(inputs[0]))
            {
                Console.WriteLine("Wrong coordinate");
                goto back;
            }
            //koordináták átalakítása int azaz tömb[0,0]-ként használhatóvá
            int row = inputs[1] - '0';
            int col = Game_Manager.letter_Space_ToIndex[inputs[0]];
            //tábla átnézése, hogy a megadott ée leellenőrzött koordináta, találat vagy üres mezőre mutat
            Console.WriteLine($"Row: {row} col: {col}");
            if (Game_Manager.battlefield_CPU[row, col] == '~')
            {
                Game_Manager.battlefield_CPU[row, col] = 'O';
                Game_Manager.battlefield_CPU_Show[row, col] = 'O';
            }
            else if (Game_Manager.battlefield_CPU[row, col] == 'S')
            {
                Game_Manager.battlefield_CPU[row, col] = 'X';
                Game_Manager.battlefield_CPU_Show[row, col] = 'X';
            }


        }
        public static void Get_Input_PlayerTwo()
        {
            Random rnd = new Random();
        back:
            //Console.WriteLine("Please give a coordinate");
            //user_Input = Console.ReadLine().ToUpper();
            //while (user_Input.Length != 2)
            //{
            //    Console.WriteLine("Not knowning coordinate try again");
            //    user_Input = Console.ReadLine().ToUpper();

            //}
            //Console.WriteLine("Coordinate lenght is good");
            //Console.WriteLine("Input is: " + user_Input);
            //char[] inputs = user_Input.ToCharArray();

            //if (!char.IsNumber(inputs[1]) || !char.IsAsciiLetter(inputs[0]))
            //{
            //    Console.WriteLine("Wrong coordinate");
            //    goto back;
            //}

            //int row = inputs[1] - '0';
            //int col = letter_Space_ToIndex[inputs[0]];
            //random koordináták kezelése CPU által
            int row_CPU = rnd.Next(0, 10);
            int col_CPU = rnd.Next(0, 10);

            Console.WriteLine($"Row: {row_CPU} col: {col_CPU}");

            if (Game_Manager.battlefield_Player[row_CPU, col_CPU] == '~')
            {
                Game_Manager.battlefield_Player[row_CPU, col_CPU] = 'O';
            }
            else if (Game_Manager.battlefield_Player[row_CPU, col_CPU] == 'S')
            {
                Game_Manager.battlefield_Player[row_CPU, col_CPU] = 'X';
            }

        }
    }
}
