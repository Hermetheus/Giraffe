using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attributes
{
    class Song
    {

        public string title;
        public string artist;
        public int duraction;
        public static int songCount = 0; //static belongs to a class
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duraction = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
