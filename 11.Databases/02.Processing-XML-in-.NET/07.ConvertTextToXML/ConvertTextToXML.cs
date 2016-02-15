namespace ConvertTextToXML
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    internal class ConvertTextToXML
    {
        private static void Main()
        {
            var fileData = GetFileData("../../contacts.txt");
            var persons = ExtractSubscribers(fileData);
            var contactsXML = GenerateContactXMLFile(persons);
            contactsXML.Save("../../contacts.xml");
        }

        private static XElement GenerateContactXMLFile(IEnumerable<Person> persons)
        {
            var contactsXML = new XElement(XName.Get("contacts"));
            foreach (var person in persons)
            {
                var personXml = new XElement("person",
                    new XElement("name", person.Name),
                    new XElement("city", person.City),
                    new XElement("phone", person.PhoneNumber));

                contactsXML.Add(personXml);
            }

            return contactsXML;
        }

        private static IEnumerable<Person> ExtractSubscribers(string fileData)
        {
            var persons = new List<Person>();

            var splittedFileData = fileData.Split('\n');
            foreach (var line in splittedFileData)
            {
                var person = line
                    .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToArray();

                persons.Add(new Person
                {
                    Name = person[0],
                    City = person[1],
                    PhoneNumber = person[2]
                });
            }

            return persons;
        }

        private static string GetFileData(string fullPath)
        {
            string data;
            using (var reader = new StreamReader(fullPath))
            {
                data = reader.ReadToEnd();
            }

            return data;
        }
    }
}