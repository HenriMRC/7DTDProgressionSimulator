using System;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class LevelRequirements
    {
        #region Attributes
        [XmlAttribute("level")]
        public string LevelXml
        {
            get => _level?.ToString();
            set => _level = Convert.ToInt32(value);
        }
        private int? _level;
        public int? Level => _level;
        #endregion

        #region Elements
        [XmlElement("requirement")]
        public Requirement[] Requirement;
        #endregion

        public LevelRequirements()
		{

		}
	}
}