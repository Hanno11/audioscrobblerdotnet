using System;
using System.Collections.Generic;
using System.Text;

namespace Audioscrobbler.NET
{
    /// <summary>
    /// Use and extend this guy for exceptions from audioscrobbler
    /// inherits from the standard Exception object
    /// </summary>
    public class AudioscrobblerException : Exception
    {
        public AudioscrobblerException()
            : base()
        {
        }

        public AudioscrobblerException(string message)
            : base(message)
        {
        }

        public AudioscrobblerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
