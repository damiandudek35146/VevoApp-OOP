using NUnit.Framework;


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
            Album firstAlbum = new Album();
            firstAlbum.Name = "Kolendy 2020";
            firstAlbum.PublishYear = 2020;
            firstAlbum.Artist = krzysztofG;
            Song track1 = new Song("Bymckfszy", krzysztofG, 13);
            var result = firstAlbum.AddSong(track1);

            Assert.IsTrue(result);
        }

        [Test]
        public void CantAddTheSameSongToAlbum()
        {
            Artist krzysztofG = new Artist();
            krzysztofG.Nick = "Gonciarz";
            Album firstAlbum = new Album();
            firstAlbum.Name = "Kolendy 2020";
            firstAlbum.PublishYear = 2020;
            firstAlbum.Artist = krzysztofG;
            Song track1 = new Song("Bymckfszy", krzysztofG, 13);
            Song track2 = new Song("Bymckfszy", krzysztofG, 13);
            firstAlbum.AddSong(track1);
            var result = firstAlbum.AddSong(track2);

            Assert.IsTrue(!result);
        }
        [Test]
        public void CreateSongObj()
        {
            Artist krzysztofG = new Artist();
            krzysztofG.Nick = "Gonciarz";
   
            Song track1 = new Song("Bymckfszy", krzysztofG, 13);

            Assert.IsNotNull(track1);
        }
        [Test]
        public void CreateArtistObj()
        {
            Artist krzysztofG = new Artist();
            krzysztofG.Nick = "Gonciarz";
            Assert.IsNotNull(krzysztofG);
        }
        [Test]
        public void CanAddAlbum()
        {
            Artist krzysztofG = new Artist();
            krzysztofG.Nick = "Gonciarz";
            Assert.IsNotNull(krzysztofG);
            Album firstAlbum = new Album();
            firstAlbum.Name = "Kolendy 2020";
            firstAlbum.PublishYear = 2020;
            firstAlbum.Artist = krzysztofG;
            Song track1 = new Song("Bymfszy", krzysztofG, 13);
            Song track2 = new Song("Bymckfszy", krzysztofG, 13);
            firstAlbum.AddSong(track2);
            firstAlbum.AddSong(track1);
            krzysztofG.AddAlbum(firstAlbum);

            Assert.IsNotNull(krzysztofG.Albums);
        }
        public void CanAddTheSameAlbum()
        {
            Artist krzysztofG = new Artist();
            krzysztofG.Nick = "Gonciarz";
            Assert.IsNotNull(krzysztofG);
            Album firstAlbum = new Album();
            firstAlbum.Name = "Kolendy 2020";
            firstAlbum.PublishYear = 2020;
            firstAlbum.Artist = krzysztofG;
            Song track1 = new Song("Bymckfszy", krzysztofG, 13);
            Song track2 = new Song("Byfszy", krzysztofG, 15);
            firstAlbum.AddSong(track2);
            firstAlbum.AddSong(track1);
            Album secondAlbum = new Album();
            secondAlbum.Name = "Bitka";
            secondAlbum.PublishYear = 2020;
            secondAlbum.Artist = krzysztofG;
            Song track3 = new Song("Bymckfszy", krzysztofG, 13);
            Song track4 = new Song("Bymy", krzysztofG, 14);
            secondAlbum.AddSong(track3);
            secondAlbum.AddSong(track4);
            krzysztofG.AddAlbum(secondAlbum);
            krzysztofG.AddAlbum(firstAlbum);
            var result=krzysztofG.AddAlbum(secondAlbum);

            Assert.IsTrue(!result);
        }
    }
}