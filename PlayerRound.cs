using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfGame
{
    static class PlayerRound
    {
        
        public static double Strike(double position, double holePosition)
        {
            
            bool isNumber;
            double angle;
            double velocity;
            Console.WriteLine("**********************************************************************");
            do
            {
                Console.Write("Enter the angle to shoot the ball: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit" || input.ToLower() == "q") throw new PlayerAbortedException();
                isNumber = double.TryParse(input, out angle);
                if(angle >= 90 || angle <= 0)
                {
                    Console.WriteLine("The angle must be greater than 0 and less than 90 degrees. Please try again.");
                    isNumber = false;
                }
            } while (!isNumber);

            do
            {
                Console.Write("Enter the velocity of the ball: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit" || input.ToLower() == "q") throw new PlayerAbortedException("Player aborted!");
                double.TryParse(input, out velocity);
                if (velocity > 100)
                {
                    Console.WriteLine("I bet you are strong, but not that strong. Try again!");
                    isNumber = false;
                }
                if(velocity < 0)
                {
                    Console.WriteLine("You are supposed to hit the ball forward!");
                    isNumber = false;
                }

            } while (!isNumber);

            double distanceTraveled = Math.Round(CalculateTrajectory(angle, velocity), 2);
            
            
            double newPosition = position > holePosition ? Math.Abs(position - distanceTraveled) : Math.Abs(position + distanceTraveled);

            return newPosition;
        }

        private static double CalculateTrajectory(double angle, double velocity)
        {
            const double GRAVITY = 9.8;
            double angleInRadians = Math.PI * angle / 180;
            double distance = Math.Pow(velocity, 2) * Math.Sin(2 * angleInRadians) / GRAVITY;
            return distance;
        }
    }
}

