using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    [XmlRoot("progression", IsNullable = false)]
    public class Progression
    {
        #region Elements
        [XmlElement(ElementName = "level", IsNullable = false)]
        public Level Level;

        [XmlElement(ElementName = "attributes", IsNullable = false)]
        public Attributes Attributes;

        [XmlElement(ElementName = "skills", IsNullable = false)]
        public Skills Skills;

        [XmlElement(ElementName = "perks", IsNullable = false)]
        public Perks Perks;
        #endregion

        public Progression()
        {

        }
    }
}
