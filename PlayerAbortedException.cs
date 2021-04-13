using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfGame
{
    class PlayerAbortedException : Exception
    {
        private static readonly string DefaultMessage = "Someone doesn't want to play anymore!";
        public PlayerAbortedException() : base(DefaultMessage)
        {
        }

        public PlayerAbortedException(string message) : base(message)
        {
        }

        public PlayerAbortedException(Exception innerException) : base(DefaultMessage, innerException)
        {
        }

        public PlayerAbortedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
