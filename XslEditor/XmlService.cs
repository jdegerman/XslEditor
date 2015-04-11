using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

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
    }
}
