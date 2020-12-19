using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VevoApp
{
    public class Album
    {
        public string Name { get; set; }
        public int PublishYear { get; set; }
        public Artist Artist { get; set; }
        public List<Song> Songs { get; set; }

        public Album(string _name, int _publishYear, Artist _artist)
        {
            Name = _name;
            PublishYear = _publishYear;
            Artist = _artist;
            Songs = new List<Song>();
        }
        public Album()
        {
            Songs = new List<Song>();
        }

        /// <summary>
        /// Method for adding new songs
        /// </summary>
        /// <param name="song">The song to be added</param>
        /// <returns>True if the song was added</returns>
        public bool AddSong(Song song)
        {
            if(!SongAlreadyExists(song))
            {
                this.Songs.Add(song);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method for checking if the same songs exists already
        /// </summary>
        /// <param name="song">The song to be checked</param>
        /// <returns>True if the same song exists inside the internal collection</returns>
        private bool SongAlreadyExists(Song song)
        {
            if (Songs != null)
            {
                return Songs.Select(p => p.Artist == song.Artist && p.LongTime == song.LongTime && p.Title == song.Title).Count() > 0;
            }
            return true;
           
            
        }
    }
}
