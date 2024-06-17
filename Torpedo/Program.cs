namespace Torpedo
{
    internal class Program
    {

        //Hajók constansokban (Még nem használt)
        public const int three_Part_Ship = 3;
        public const int four_Part_Ship = 4;
        public const int five_Part_Ship = 5;
        static void Main(string[] args)
        {
            int player_Num = 1;
            Welcome_Words.Print_Welcome();
            Welcome_Words.Battle_Start_Counter();

            Game_Manager.Random_Battlefield_Generator(Game_Manager.battlefield_Player);
            Game_Manager.Random_Battlefield_Generator(Game_Manager.battlefield_CPU);

            Game_Manager.Game_Manager_Operator(player_Num);


            Console.WriteLine("That was a good game");



            Console.ReadLine();
        }
    }
}

