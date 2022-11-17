using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class EffectGroupRequirement
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

        [XmlAttribute("tags")]
        public string TagsXml
        {
            get => _tags;
            set => _tags = value;
        }
        private string _tags;
        public string Tags => _tags;
        #endregion

        public EffectGroupRequirement()
        {

        }
    }
}
