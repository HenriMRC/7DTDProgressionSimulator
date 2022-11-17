using System;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class EffectDescription
    {
        #region Attributes
        [XmlAttribute("level")]
        public string LevelXml
        {
            get => _level.ToString();
            set => _level = Convert.ToInt32(value);
        }
        private int _level;
        public int Level => _level;

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
        #endregion


        public EffectDescription()
        {

        }
    }
}