using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfGame
{
    public class GameRound
    {
        public int CourtLength { get; set; }

        public double PlayerPosition { get; set; }

        public double HolePosition { get; set; }

        public void RunGame()
        {
            RandomiseCourt();
            int maxTries = 10;
            Console.WriteLine("Welcome to this golf game.");
            Console.WriteLine($"This golf course length is {CourtLength}m long and the hole is placed at {HolePosition}m");
            Console.WriteLine("To score you need to get the ball 0.5m or closer to the hole. You have {0} tries", maxTries);
            
            GameLogger game = new GameLogger();

            double oldPosition;
            double position = 0;
            int numberofStrikes = 0;
            double distanceToHole = Math.Abs(HolePosition - position);

            while (distanceToHole >= 1)
            {
                numberofStrikes++;
                
                oldPosition = position;
                position = Math.Round(PlayerRound.Strike(oldPosition, HolePosition), 2);
                if (position > CourtLength) throw new OutOfBoundsException();

                distanceToHole = Math.Round(Math.Abs(HolePosition - position), 2);

                if (numberofStrikes > maxTries) throw new OutOfTriesException($"You failed to reach the hole in less than {maxTries} tries.");

                game.logRound(numberofStrikes, distanceToHole, oldPosition);
                double distanceTravelled = Math.Round(Math.Abs(position - oldPosition), 2);

                Console.WriteLine("**********************************************************************");
                Console.WriteLine($"Strike nr: {numberofStrikes}. The ball traveled {distanceTravelled}m and your new position is at {position}m");
                Console.WriteLine($"You are {distanceToHole} meter {(HolePosition - position > 0 ? "from" : "beyond")} the hole.");

            }

            game.PrintLog();
            Console.ReadKey();
        }


        private void RandomiseCourt()
        {
            Random rnd = new Random();
            CourtLength = rnd.Next(500, 1500);
            double distanceFromEndInPercentage = CourtLength * rnd.Next(10, 15) / 100;
            HolePosition = CourtLength - distanceFromEndInPercentage;
        }
    }
}
