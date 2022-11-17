using System;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class Skills
    {
        #region Attributes
        [XmlAttribute("min_level")]
        public string MinLevelXml
        {
            get => _minLevel.ToString();
            set => _minLevel = Convert.ToInt32(value);
        }
        private int _minLevel;
        public int MinLevel => _minLevel;

        [XmlAttribute("max_level")]
        public string MaxLevelXml
        {
            get => _maxLevel.ToString();
            set => _maxLevel = Convert.ToInt32(value);
        }
        private int _maxLevel;
        public int MaxLevel => _maxLevel;
        #endregion

        #region Element
        [XmlElement("skill")]
        public Skill[] skill;
        #endregion

        public Skills()
        {

        }
    }
}