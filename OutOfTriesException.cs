using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfGame
{
    class OutOfTriesException : Exception
    {
        private static readonly string DefaultMessage = "Too many tries. The game is over.";
        public OutOfTriesException() : base(DefaultMessage)
        {
        }

        public OutOfTriesException(string message) : base(message)
        {
        }

        public OutOfTriesException(Exception innerException) : base(DefaultMessage, innerException)
        {
        }

        public OutOfTriesException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
