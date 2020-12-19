using System;
using System.Collections.Generic;
using System.Text;

namespace VevoApp
{
    public class Artist
    {
        public string Nick { get; set; }
        public List<Album> Albums { get; set; }

        public bool AddAlbum(Album _album)
        {

            foreach (Album a in Albums)
            {
                // Chcking if new album not exist in albums
                if (_album.Name != a.Name && _album.PublishYear != a.PublishYear)
                {
                    Albums.Add(_album);
                    
                }
                
            }
            return false;
        }
    }
}
