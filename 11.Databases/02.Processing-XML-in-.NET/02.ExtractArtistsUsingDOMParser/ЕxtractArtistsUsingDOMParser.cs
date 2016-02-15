namespace ЕxtractArtistsUsingDOMParser
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    internal class ЕxtractArtistsUsingDOMParser
    {
        private static void Main()
        {
            // Initialization
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01.CreateXMLCatalog/catalog.xml");

            // <catalog> --> root element
            var rootNode = xmlDoc.DocumentElement;

            // Extract all artists and print them
            var artists = ExtractAllArtists(rootNode);
            Console.WriteLine("All artists in the catalog:\n{0}", string.Join(", ", artists));

            Console.WriteLine(new string('-', 37));

            // Print the number of albums for each artist
            var albums = ExtractNumberOfAlbumsForEachArtist(rootNode);
            foreach (var album in albums)
            {
                Console.WriteLine("{0}: {1} album(s)", album.Key, album.Value);
            }

            Console.WriteLine(new string('-', 37));
        }

        private static IDictionary<string, int> ExtractNumberOfAlbumsForEachArtist(XmlElement rootNode)
        {
            var output = new Dictionary<string, int>();

            var albums = rootNode.GetElementsByTagName("album");
            foreach (XmlNode album in albums)
            {
                var artist = album["artist"].InnerText;
                if (!output.ContainsKey(artist))
                {
                    output[artist] = 0;
                }

                output[artist]++;
            }

            return output;
        }

        private static IEnumerable<string> ExtractAllArtists(XmlElement rootNode)
        {
            var output = new HashSet<string>();

            var albums = rootNode.GetElementsByTagName("album");
            foreach (XmlNode album in albums)
            {
                output.Add(album["artist"].InnerText);
            }

            return output;
        }
    }
}