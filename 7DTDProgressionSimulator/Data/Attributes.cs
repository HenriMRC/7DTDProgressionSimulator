using System;
using System.Globalization;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class Attributes
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

        [XmlAttribute("base_skill_point_cost")]
        public string BaseSkillPointCostXml
        {
            get => _baseSkillPointCost.ToString();
            set => _baseSkillPointCost = Convert.ToInt32(value);
        }
        private int _baseSkillPointCost;
        public int BaseSkillPointCost => _baseSkillPointCost;

        [XmlAttribute("cost_multiplier_per_level")]
        public string CostMultiplierPerLevelXml
        {
            get => _costMultiplierPerLevel.ToString();
            set => _costMultiplierPerLevel = Convert.ToSingle(value);
        }
        private float _costMultiplierPerLevel;
        public float CostMultiplierPerLevel => _costMultiplierPerLevel;
        #endregion

        #region Elements
        [XmlElement("attribute")]
        public Attribute[] Attribute;
        #endregion

        public Attributes()
        {

        }
    }
}