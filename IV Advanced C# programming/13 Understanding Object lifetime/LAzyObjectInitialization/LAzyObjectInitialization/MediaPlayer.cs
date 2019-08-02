using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAzyObjectInitialization
{
    // The MediaPlayer has an AllTracks object.
    class MediaPlayer
    {
        // Assume these methods do something useful.
        public void Play() { /*play a song */ }
        public void Pause() { /*pause the song */ }
        public void Stop() { /*stop playback*/ }
        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() => 
            {
                Console.WriteLine("Creating AllTracks object!");
                return new AllTracks();
            } 
        );
        
        public AllTracks GetAllTracks()
        {
            // Return all of the songs.
            return allSongs.Value;
        }

    }
}
