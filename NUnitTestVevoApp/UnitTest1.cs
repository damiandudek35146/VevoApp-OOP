using NUnit.Framework;
using NUnitTestVevoApp;

namespace VevoApp
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
      
        }

        [Test]
        public void AddSongToAlbum()
        {
            Artist krzysztofG = new Artist();
            krzysztofG.Nick = "Gonciarz";

            TestAlbum testAlbum = new TestAlbum();
            testAlbum.Artist = null;

            Album firstAlbum = new Album();
            firstAlbum.Name = "Kolendy 2020";
            firstAlbum.PublishYear = 2020;
            firstAlbum.Artist = krzysztofG;


            Song track1 = new Song("Bymckfszy", krzysztofG, 13);
            var result = firstAlbum.AddSong(track1);



            Assert.IsTrue(result);
        }
    }
}