namespace ExtractSongTitlesUsingXMLReader
{
    using System;
    using System.Xml;

    internal class ExtractSongTitlesUsingXMLReader
    {
        private static void Main()
        {
            Console.WriteLine("All song titles in the catalog:");
            Console.WriteLine(new string('-', 31));
            using (var reader = XmlReader.Create("../../../01.CreateXMLCatalog/catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}