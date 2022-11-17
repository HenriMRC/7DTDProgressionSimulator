using System;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class PassiveEffect
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

        [XmlAttribute("level")]
        public string LevelXml
        {
            get
            {
                return string.Join(',', _level);
            }
            set
            {
                string[] values = value.Split(',');
                _level = new int[values.Length];
                for (int i = 0; i < values.Length; i++)
                    _level[i] = Convert.ToInt32(values[i]);
            }
        }
        private int[] _level;
        public int[] Level => _level;

        [XmlAttribute("value")]
        public string ValueXml
        {
            get
            {
                return string.Join(',', _level);
            }
            set
            {
                string[] values = value.Split(',');
                _value = new float[values.Length];
                for (int i = 0; i < values.Length; i++)
                    _value[i] = Convert.ToSingle(values[i]);
            }
        }
        private float[] _value;
        public float[] Value => _value;

        [XmlAttribute("tags")]
        public string TagsXml
        {
            get => _tags;
            set => _tags = value;
        }
        private string _tags;
        public string Tags => _tags;
        #endregion


        public PassiveEffect()
        {

        }
    }
}