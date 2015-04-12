using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;

namespace XslEditor
{
    internal static class XmlService
    {
        public static bool TryLoadXml(this XmlDocument xdoc, string xml, ref string error)
        {
            error = null;
            try 
            {
                xdoc.LoadXml(xml);
                return true;
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public static bool ValidateXml(string path, ref string error)
        {
            error = null;
            try
            {
                using (var reader = XmlReader.Create(path))
                    while (reader.Read()) ;
                return true;
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public static XmlDocument GetXDoc()
        {
            return new XmlDocument();
        }
        public static XmlDocument LoadInstance(string filename)
        {
            var xdoc = GetXDoc();
            xdoc.Load(filename);
            return xdoc;
        }
        public static XmlReader CreateReader(string file)
        {
            return XmlReader.Create(file, new XmlReaderSettings { IgnoreComments = true, IgnoreProcessingInstructions = true, IgnoreWhitespace = true });
        }
        public static XmlSchemaSet CreateSchemaSet(string file)
        {
            var set = new XmlSchemaSet();
            set.Add(XmlSchema.Read(CreateReader(file), new ValidationEventHandler((sender, e) => { throw e.Exception; })));
            set.Compile();
            return set;
        }
        public static List<string> GetTargetNamespaces(this XmlSchemaSet set)
        {
            var ns = new HashSet<string>();
            foreach (XmlSchema schema in set.Schemas())
                ns.Add(schema.TargetNamespace);
            return ns.ToList();
        }
        public static string PrettyPrint(string xml, bool includeXmlDeclaration = true)
        {
            using(var output = new MemoryStream())
            using (var writer = XmlWriter.Create(output, new XmlWriterSettings { Indent = true, Encoding = GetEncoding(), OmitXmlDeclaration = !includeXmlDeclaration }))
            {
                var xdoc = GetXDoc();
                xdoc.LoadXml(xml);
                xdoc.WriteContentTo(writer);
                writer.Flush();
                writer.Close();
                return GetEncoding().GetString(output.ToArray());
            }
        }
        public static string Transform(string xmlPath, string xsl)
        {
            if (string.IsNullOrEmpty(xmlPath))
                throw new Exception("No XML instance specified");
            using (var inputStream = new MemoryStream(GetEncoding().GetBytes(xsl)))
            {
                inputStream.Seek(0, SeekOrigin.Begin);
                using (var reader = XmlReader.Create(inputStream))
                {
                    var transform = new XslCompiledTransform(true);
                    var settings = new XsltSettings { EnableDocumentFunction = true, EnableScript = true };
                    transform.Load(reader, settings, null);
                    using (var outputStream = new MemoryStream())
                    using (var writer = XmlWriter.Create(outputStream, new XmlWriterSettings { Indent = true, WriteEndDocumentOnClose = true, Encoding = GetEncoding() }))
                    {
                        transform.Transform(xmlPath, writer);
                        writer.Flush();
                        writer.Close();
                        return GetEncoding().GetString(outputStream.ToArray());
                    }
                }
            }
        }
        private static UTF8Encoding GetEncoding()
        {
            return new UTF8Encoding(false);
        }
    }
}
