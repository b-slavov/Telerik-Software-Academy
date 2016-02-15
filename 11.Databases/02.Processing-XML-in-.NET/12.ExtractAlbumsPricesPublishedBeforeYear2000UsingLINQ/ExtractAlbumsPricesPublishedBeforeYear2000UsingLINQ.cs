namespace ExtractAlbumsPricesPublishedBeforeYear2000UsingLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class ExtractAlbumsPricesPublishedBeforeYear2000UsingLINQ
    {
        private static void Main()
        {
            var xmlDoc = XDocument.Load("../../../01.CreateXMLCatalog/catalog.xml");
            var albums =
                from album in xmlDoc.Descendants("album")
                where album.Element("year").Value.Contains("19")
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            foreach (var album in albums)
            {
                Console.WriteLine("{0}: {1}$", album.Name, album.Price);
            }
        }
    }
}