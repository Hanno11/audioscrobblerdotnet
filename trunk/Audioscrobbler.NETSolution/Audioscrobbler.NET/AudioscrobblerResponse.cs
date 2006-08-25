using System;
using System.Collections.Generic;
using System.Text;

namespace Audioscrobbler.NET
{
    /// <summary>
    /// Wraps the text response from the audioscrobbler request
    /// </summary>
    internal class AudioscrobblerResponse
    {
        // the type of response this is
        private AudioscrobblerResponseType type;

        // the wait interval for the next response
        private int interval;

        // any other variables associated with this response
        private IDictionary<string, string> variables;

        public AudioscrobblerResponse()
        {
            variables = new Dictionary<string, string>();
        }

        // any other variables associated with this response
        public IDictionary<string, string> Variables
        {
            get { return variables; }
            set { variables = value; }
        }

        // the wait interval for the next response
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        // the type of response this is
        public AudioscrobblerResponseType Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
