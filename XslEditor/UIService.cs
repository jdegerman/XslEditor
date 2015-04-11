using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace XslEditor
{
    internal static class UIService
    {
        public static void OpenFile(string filter, Action<string> onOpen)
        {
            using(var ofd = new OpenFileDialog { Filter = filter, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.Cancel)
                    return;
                onOpen(ofd.FileName);
            }
        }
        public static void OpenFiles(string filter, Action<string> onOpen)
        {
            using (var ofd = new OpenFileDialog { Filter = filter, Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.Cancel)
                    return;
                ofd.FileNames.ForEach(file => onOpen(file));
            }
        }
        public static void OpenFiles(string filter, Action<string[]> onOpen)
        {
            using (var ofd = new OpenFileDialog { Filter = filter, Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.Cancel)
                    return;
                onOpen(ofd.FileNames);
            }
        }
        private static void ForEach<T>(this T[] array, Action<T> onEach)
        {
            foreach (var item in array)
                onEach(item);
        }
        public static void PopulateInstanceTree(TreeView target, Func<string, XmlReader> readerSource, string instancePath)
        {
            using (var reader = readerSource(instancePath))
            {
                reader.MoveToContent();
                var root = target.Nodes.Add(reader.Name);
                if (reader.HasAttributes)
                    AddAttributes(root, reader);
                while (reader.Read() && reader.NodeType != XmlNodeType.EndElement)
                    AddChildren(root.Nodes, reader);
            }
        }

        private static void AddChildren(TreeNodeCollection target, XmlReader reader)
        {
            var root = target.Add(reader.Name);
            if (reader.HasAttributes)
                AddAttributes(root, reader);
            while(reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                        AddChildren(root.Nodes, reader);
                        break;
                    case XmlNodeType.Text:
                        root.Nodes.Add("#text=" + reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        return;
                    default:
                        break;
                }
                Application.DoEvents();
            }
        }

        private static void AddAttributes(TreeNode target, XmlReader reader)
        {
            var attrRoot = target.Nodes.Add("@attributes");
            if (!reader.MoveToFirstAttribute())
                return;
            do
            {
                attrRoot.Nodes.Add(reader.Name + " = " + reader.Value);
            } while (reader.MoveToNextAttribute());
        }

        public static void PopulateSchemaTree(TreeView targetTreeSchema, Func<string, XmlSchemaSet> schemaSetSource, string schemaPath, Func<List<string>, string> selectRootCallback)
        {
            var schemaSet = schemaSetSource(schemaPath);
            var nsList = schemaSet.GetTargetNamespaces();
            var ns = string.Empty;
            if (nsList.Count > 0)
                ns = nsList.First();
            XmlSchema schema = null;
            foreach(XmlSchema _schema in schemaSet.Schemas(ns))
            {
                schema = _schema;
                break;
            }
            if (schema == null)
                throw new Exception("Unable to load schema from specified file");
            if(schema.Elements.Count == 0)
                throw new Exception("Selected schema does not contain any root elements");
            var nodes = new List<string>();
            foreach(DictionaryEntry entry in schema.Elements)
            {
                nodes.Add(GetFriendlyName(entry.Key.ToString()));
            }
            var rootNode = selectRootCallback(nodes);
            foreach(DictionaryEntry entry in schema.Elements)
            {
                if (GetFriendlyName(entry.Key.ToString()) != rootNode)
                    continue;
                var element = (XmlSchemaElement)entry.Value;
                AddSchemaNodes(targetTreeSchema.Nodes, element);
            }
        }
        public static string SelectRootElementCallback(List<string> elements)
        {
            if (elements.Count == 1)
                return elements.First();
            using (var selectRoot = new SelectRootElementForm(elements))
            {
                selectRoot.ShowDialog();
                return selectRoot.RootElement;
            }
        }
        private static void AddSchemaNodes(TreeNodeCollection target, XmlSchemaElement element)
        {
            var root = target.Add(element.QualifiedName.Name + " : " + (element.SchemaTypeName.IsEmpty ? "" : element.SchemaTypeName.Name + " / ") + GetOccurs(element.MinOccursString) + " / " + GetOccurs(element.MaxOccursString));
            if(element.ElementSchemaType is XmlSchemaComplexType)
            {
                ProcessComplexType(root.Nodes, (XmlSchemaComplexType)element.ElementSchemaType);
            }
            else
            {
                ProcessSimpleType(root.Nodes, (XmlSchemaSimpleType)element.ElementSchemaType);
            }
        }

        private static void ProcessSimpleType(TreeNodeCollection target, XmlSchemaSimpleType simpleType)
        {
            if (!string.IsNullOrEmpty(simpleType.Name))
            {
                target.Add(simpleType.Name + " / " + simpleType.TypeCode.ToString());
            }
        }
        private static void ProcessComplexType(TreeNodeCollection target, XmlSchemaComplexType complexType)
        {
            IDictionaryEnumerator enumerator = complexType.AttributeUses.GetEnumerator();
            while(enumerator.MoveNext())
            {
                var attribute = (XmlSchemaAttribute)enumerator.Value;
                target.Add("@" + attribute.QualifiedName.Name + " / " + GetAttributeType(attribute));
            }
            if (complexType.ContentTypeParticle is XmlSchemaSequence)
            {
                ProcessCollection(target, ((XmlSchemaSequence)complexType.ContentTypeParticle).Items);
            }
            else if (complexType.ContentTypeParticle is XmlSchemaAll)
            {
                ProcessCollection(target, ((XmlSchemaAll)complexType.ContentTypeParticle).Items);
            }
            else if (complexType.ContentTypeParticle is XmlSchemaChoice)
            {
                ProcessCollection(target, ((XmlSchemaChoice)complexType.ContentTypeParticle).Items);
            }
            else
            {
            }
        }
        private static void ProcessCollection(TreeNodeCollection target, XmlSchemaObjectCollection collection)
        {
            foreach(XmlSchemaObject item in collection)
            {
                if(item is XmlSchemaElement)
                {
                    AddSchemaNodes(target, (XmlSchemaElement)item);
                }
            }
        }
        private static string GetAttributeType(XmlSchemaAttribute attribute)
        {
            if (attribute.SchemaType != null && attribute.SchemaType.Name != null)
                return attribute.SchemaType.Name;
            if (attribute.AttributeSchemaType != null && attribute.AttributeSchemaType.BaseXmlSchemaType != null)
                return attribute.AttributeSchemaType.BaseXmlSchemaType.Datatype.TypeCode.ToString();
            if (attribute.SchemaTypeName != null && !attribute.SchemaTypeName.IsEmpty)
                return attribute.SchemaTypeName.Name;
            return "##any";
        }
        private static string GetFriendlyName(string name)
        {
            var parts = name.Split(':');
            name = parts.Last();
            if (parts.Length > 1)
                name += " : " + string.Join(":", parts.ToList().GetRange(0, parts.Length - 1));
            return name;
        }
        private static string GetOccurs(string occurs)
        {
            return string.IsNullOrEmpty(occurs) ? "1" : occurs;
        }
        private static void ForEach(this XmlSchemaObjectTable table, Action<DictionaryEntry> fn)
        {
            foreach (DictionaryEntry item in table)
                fn(item);
        }
    }
}
