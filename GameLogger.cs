using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfGame
{
    class GameLogger
    {
        List<RoundLogger> rounds = new List<RoundLogger>();
        
        public void logRound(int strikeNr, double distanceToHole, double position)
        {
            rounds.Add(new RoundLogger()
            {
                StrikeNr = strikeNr,
                DistanceToHole = distanceToHole,
                Position = position
            });
        }

        public void PrintLog()
        {
            foreach (var round in rounds)
            {
                round.PrintOutput();
            }


        }
    }
}
