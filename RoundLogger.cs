using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfGame
{
    class RoundLogger
    {
        public int StrikeNr { get; set; }

        public double DistanceToHole { get; set; }

        public double Position { get; set; }

        public void PrintOutput()
        {
            Console.WriteLine($"Strike nr: {StrikeNr} started at pos: {Position} and landed {DistanceToHole}m from the hole.");
        }

    }
}
