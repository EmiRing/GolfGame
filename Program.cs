using System;

namespace GolfGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            while (active)
            {

                GameRound round = new GameRound();
                try
                {
                    round.RunGame();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("Do you want to play again (Y/N)? ");
                
                active = Console.ReadLine().ToLower() == "y" ? true : false;
                Console.Clear();
            }

        }

    }
}
