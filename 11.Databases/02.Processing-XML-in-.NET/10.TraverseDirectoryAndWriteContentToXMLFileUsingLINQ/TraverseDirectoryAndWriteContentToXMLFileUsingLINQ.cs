﻿namespace TraverseDirectoryAndWriteContentToXMLFileUsingLINQ
{
    using System.IO;
    using System.Xml.Linq;

    internal class TraverseDirectoryAndWriteContentToXMLFileUsingLINQ
    {
        private const string RootDirectory = @"E:\IT\Projects\11.Databases\02.XML-Processing-in-.NET";

        private static void Main()
        {
            GenerateXmlDirectoryTree();
        }

        private static void GenerateXmlDirectoryTree()
        {
            var rootDir = new DirectoryInfo(RootDirectory);
            var xmlDirTree = GenerateXmlDirectoryTree(rootDir);
            var xDoc = new XDocument(xmlDirTree);
            xDoc.Save("../../directory.xml");
        }

        private static XElement GenerateXmlDirectoryTree(DirectoryInfo rootDir)
        {
            var dirsXml = new XElement("root");
            var subtreeXml = GenerateXmlDirectoryTreeRecursively(rootDir);
            dirsXml.Add(subtreeXml);

            return dirsXml;
        }

        private static XElement GenerateXmlDirectoryTreeRecursively(DirectoryInfo rootDir)
        {
            var dirXml = new XElement("dir", new XAttribute("name", rootDir.Name));

            foreach (var file in rootDir.GetFiles())
            {
                var fileXml = new XElement("file", new XAttribute("name", file.Name));
                dirXml.Add(fileXml);
            }

            foreach (var directory in rootDir.GetDirectories())
            {
                dirXml.Add(GenerateXmlDirectoryTreeRecursively(directory));
            }

            return dirXml;
        }
    }
}