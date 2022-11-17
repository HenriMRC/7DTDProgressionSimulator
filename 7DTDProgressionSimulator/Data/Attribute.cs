using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class Attribute
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

        [XmlAttribute("icon")]
        public string IconXml
        {
            get => _icon;
            set => _icon = value;
        }
        private string _icon;
        public string Icon => _icon;

        [XmlAttribute("min_level")]
        public string MinLevelXml
        {
            get => _minLevel?.ToString();
            set => _minLevel = Convert.ToInt32(value);
        }
        private int? _minLevel;
        public int? MinLevel => _minLevel;

        [XmlAttribute("max_level")]
        public string MaxLevelXml
        {
            get => _maxLevel?.ToString();
            set => _maxLevel = Convert.ToInt32(value);
        }
        private int? _maxLevel;
        public int? MaxLevel => _maxLevel;

        [XmlAttribute("base_skill_point_cost")]
        public string BaseSkillPointCostXml
        {
            get => _baseSkillPointCost?.ToString();
            set => _baseSkillPointCost = Convert.ToInt32(value);
        }
        private int? _baseSkillPointCost;
        public int? BaseSkillPointCost => _baseSkillPointCost;
        #endregion

        #region Elements
        [XmlElement("level_requirements")]
        public LevelRequirements[] LevelRequirements;

        [XmlElement("effect_group")]
        public EffectGroup[] EffectGroup;
        #endregion

        public Attribute()
        {

        }
    }
}
