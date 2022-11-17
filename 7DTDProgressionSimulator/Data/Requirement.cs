using System;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
	public class Requirement
    {
        #region Attributes
        [XmlAttribute("name")]
        public string NameXml
        {
            get => _name;
            set => _name = value;
        }
        private string _name;
        public string Name => _name;

        [XmlAttribute("operation")]
        public string OperationXml
        {
            get => _operation;
            set => _operation = value;
        }
        private string _operation;
        public string Operation => _operation;

        [XmlAttribute("value")]
        public string ValueXml
        {
            get => _value.ToString();
            set => _value = Convert.ToInt32(value);
        }
        private int _value;
        public int Value => _value;

        [XmlAttribute("desc_key")]
        public string DescKeyXml
        {
            get => _descKey;
            set => _descKey = value;
        }
        private string _descKey;
        public string DescKey => _descKey;
        #endregion

        public Requirement()
        {

        }
    }
}
