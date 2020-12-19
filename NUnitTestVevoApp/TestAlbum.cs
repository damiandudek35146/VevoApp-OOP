using System;
using System.Collections.Generic;
using System.Text;
using VevoApp;

namespace NUnitTestVevoApp
{
    public class TestAlbum
    {
        public string Name { get; set; }
        public int PublishYear { get; set; }
        public Artist Artist { get; set; }
        public List<Song> Songs { get; set; }

        public TestAlbum()
        {
            this.Artist.Nick = "";
        }
    }
}
