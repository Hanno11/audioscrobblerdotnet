using System;
using System.Collections.Generic;
using System.Text;

namespace Audioscrobbler.NET
{
    /// <summary>
    /// Interface to a track submitted to Audioscrobbler
    /// </summary>
    public interface IAudioscrobblerTrack
    {
        string ArtistName { get; set; }
        string TrackName { get; set; }
        string AlbumName { get; set; }
        string MusicBrainzID { get; set; }
        int TrackLength { get; set; }
    }
}
