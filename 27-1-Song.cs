using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;            //static attribute 

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }    
        
        public int GetSongCount()
        {
            return songCount;
        }
    }
}
