using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VevoApp
{
    public class Artist
    {
        public string Nick { get; set; }
        public List<Album> Albums { get; set; }

        public Artist()
        {
            this.Nick = "";
            this.Albums = new List<Album>();
        }
        /// <summary>
        /// Method for adding new albums
        /// </summary>
        /// <param name="_album">The album to be added</param>
        /// <returns>True if the album was added</returns>
        public bool AddAlbum(Album album)
        {
            if(AlbumAlreadyExists(album))
            {
                this.Albums.Add(album);
                return true;

            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Method for checking if the same album exists already
        /// </summary>
        /// <param name="album">The album to be checked</param>
        /// <returns>True if the same album exists inside the internal collection</returns>
        private bool AlbumAlreadyExists(Album album)
        {
            if (Albums != null)
            {
                return Albums.Select(p => p.Name == album.Name && p.PublishYear == album.PublishYear && p.Artist == album.Artist && p.Songs == album.Songs).Count() > 0;
            }
            return true;

        }
    }
}
