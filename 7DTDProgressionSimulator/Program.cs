using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //will not stay here
            string xmlFile = AppDomain.CurrentDomain.BaseDirectory + "progression.xml";
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Stream stream = File.OpenRead(xmlFile);

            XmlSerializer serializer = new XmlSerializer(typeof(Progression));
            serializer.UnknownAttribute += OnUnknownAttribute;
            serializer.UnknownElement += OnUnknownElement;
            serializer.UnknownNode += OnUnknownNode;
            serializer.UnreferencedObject += OnUnreferencedObject;
            
            /*
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            writerSettings.OmitXmlDeclaration = true;
            */
            
            Progression progression = ReadXML(stream, serializer);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Controller());
        }

        private static Progression ReadXML(Stream stream, XmlSerializer serializer)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader reader = XmlReader.Create(stream, settings);

            return (Progression)serializer.Deserialize(reader);
        }

        private static void OnUnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            Console.WriteLine($"OnUnknownAttribute: {e.LineNumber}, {e.LinePosition}: {e.ExpectedAttributes} [{e.Attr.ParentNode?.Name}]");
        }

        private static void OnUnknownElement(object sender, XmlElementEventArgs e)
        {
            Console.WriteLine($"OnUnknownElement: {e.LineNumber}, {e.LinePosition}: {e.ExpectedElements} [{e.Element.ParentNode?.Name}]");
        }

        private static void OnUnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine($"OnUnknownNode: {e.LineNumber}, {e.LinePosition}: {e.Name} [{e.LocalName}] {e.NodeType}");
        }

        private static void OnUnreferencedObject(object sender, UnreferencedObjectEventArgs e)
        {
            Console.WriteLine($"OnUnreferencedObject: {e.UnreferencedObject.ToString()}, {e.GetType().ToString()}");
        }
    }

    class Controller : ApplicationContext
    {
        private readonly Layout _layout;

        internal Controller()
        {
            _layout = new Layout();
            _layout.FormClosed += OnLayoutClosed;
            _layout.Show();
        }

        private void OnLayoutClosed(object sender, EventArgs e)
        {
            ExitThread();
        }
    }

    class Layout : Form
    {
        public Layout()
        {
            //ClientSize = m_Board.Size;
            //MaximumSize = MinimumSize = Size;
        }
    }

    class Model
    {

    }

}
