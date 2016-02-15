namespace XSLTransformation
{
    using System.Xml.Xsl;

    internal class XSLTransformation
    {
        private static void Main()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xsl");
            xslt.Transform("../../../01.CreateXMLCatalog/catalog.xml", "../../catalog.html");
        }
    }
}