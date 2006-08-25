using System;
using System.Collections.Generic;
using System.Text;

namespace Audioscrobbler.NET
{
    /// <summary>
    /// The various types of responses that can be 
    /// returned by the audioscrobbler servers
    /// </summary>
    internal enum AudioscrobblerResponseType
    {
        UNKNOWN,
        UPTODATE,
        UPDATE,
        FAILED,
        BADUSER,
        BADAUTH,
        OK
    }
}
