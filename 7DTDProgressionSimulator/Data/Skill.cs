using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class Skill
    {
        #region Attribute
        [XmlAttribute("name")]
        public string NameXml
        {
            get => _name;
            set => _name = value;
        }
        private string _name;
        public string Name => _name;

        [XmlAttribute("parent")]
        public string ParentXml
        {
            get => _parent;
            set => _parent = value;
        }
        private string _parent;
        public string Parent => _parent;

        [XmlAttribute("name_key")]
        public string NameKeyXml
        {
            get => _nameKey;
            set => _nameKey = value;
        }
        private string _nameKey;
        public string NameKey => _nameKey;

        [XmlAttribute("desc_key")]
        public string DescKeyXml
        {
            get => _descKey;
            set => _descKey = value;
        }
        private string _descKey;
        public string DescKey => _descKey;

        [XmlAttribute("long_desc_key")]
        public string LongDescKeyXml
        {
            get => _longDescKey;
            set => _longDescKey = value;
        }
        private string _longDescKey;
        public string LongDescKey => _longDescKey;

        [XmlAttribute("icon")]
        public string IconXml
        {
            get => _icon;
            set => _icon = value;
        }
        private string _icon;
        public string Icon => _icon;
        #endregion

        #region Elements
        [XmlElement("effect_group")]
        public EffectGroup EffectGroup;
        #endregion

        public Skill()
        {

        }
    }
}