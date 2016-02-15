namespace ExtractAlbumsPricesPublishedBeforeYear2000UsingXPath
{
    using System;
    using System.Xml;

    internal class ExtractAlbumsPricesPublishedBeforeYear2000UsingXPath
    {
        private static void Main()
        {
            const string xPathQuery = "/catalog/album[year]";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01.CreateXMLCatalog/catalog.xml");

            var albumsList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode albumNode in albumsList)
            {
                var year = int.Parse(albumNode.SelectSingleNode("year").InnerText);
                if (year < 2000)
                {
                    var albumName = albumNode.SelectSingleNode("name").InnerText;
                    var albumPrice = albumNode.SelectSingleNode("price").InnerText;
                    Console.WriteLine("{0}: {1}$", albumName, albumPrice);
                }
            }
        }
    }
}