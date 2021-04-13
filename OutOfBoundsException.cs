using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfGame
{
    class OutOfBoundsException : Exception
    {
        private static readonly string DefaultMessage = "The ball was sent out of bounds. The game is over.";

        public OutOfBoundsException() : base(DefaultMessage)
        {
        }

        public OutOfBoundsException(string message) : base(message) 
        {
        }

        public OutOfBoundsException(Exception innerException) : base(DefaultMessage, innerException)
        {
        }

        public OutOfBoundsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
