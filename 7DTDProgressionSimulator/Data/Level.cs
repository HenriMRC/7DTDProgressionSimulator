using System;
using System.Globalization;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class Level
    {
        #region Attributes
        [XmlAttribute("max_level")]
        public string MaxLevelXml
        {
            get => _maxLevel.ToString();
            set => _maxLevel = Convert.ToInt32(value);
        }
        private int _maxLevel;
        public int MaxLevel => _maxLevel;

        [XmlAttribute("exp_to_level")]
        public string ExpToLevelXml
        {
            get => _expToLevel.ToString();
            set => _expToLevel = Convert.ToSingle(value);
        }
        private float _expToLevel;
        public float ExpToLevel => _expToLevel;

        [XmlAttribute("experience_multiplier")]
        public string ExperienceMultiplierXml
        {
            get => _experienceMultiplier.ToString();
            set => _experienceMultiplier = Convert.ToSingle(value);
        }
        private float _experienceMultiplier;
        public float ExperienceMultiplier => _experienceMultiplier;

        [XmlAttribute("skill_points_per_level")]
        public string SkillPointsPerLevelXml
        {
            get => _skillPointsPerLevel.ToString();
            set => _skillPointsPerLevel = Convert.ToInt32(value);
        }
        private int _skillPointsPerLevel;
        public int SkillPointsPerLevel => _skillPointsPerLevel;

        [XmlAttribute("clamp_exp_cost_at_level")]
        public string ClampExpCostAtLevelXml
        {
            get => _clampExpCostAtLevelLevel.ToString();
            set => _clampExpCostAtLevelLevel = Convert.ToInt32(value);
        }
        private int _clampExpCostAtLevelLevel;
        public int ClampExpCostAtLevel => _clampExpCostAtLevelLevel;
        #endregion

        public Level()
        {

        }
    }
}
