namespace ExtractSongTitlesUsingLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class ExtractSongTitlesUsingLINQ
    {
        private static void Main()
        {
            var xmlDoc = XDocument.Load("../../../01.CreateXMLCatalog/catalog.xml");
            var songs =
                from song in xmlDoc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };

            Console.WriteLine("All song titles in the catalog:");
            Console.WriteLine(new string('-', 31));
            foreach (var song in songs)
            {
                Console.WriteLine(song.Title);
            }
        }
    }
}