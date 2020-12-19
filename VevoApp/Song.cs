using System;
using System.Collections.Generic;
using System.Text;

namespace VevoApp
{
    public class Song
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public int LongTime { get; set; }

        public Song(string _title, Artist _artist, int _longTime)
        {
            Title = _title;
            Artist = _artist;
            if (_longTime > 0)
            { 
                LongTime = _longTime; 
            }
        }
    }
}
