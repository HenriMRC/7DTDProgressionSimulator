using System;
using System.Xml.Serialization;

namespace SDTDProgressionSimulator
{
    public class EffectGroup
    {
		#region Elements
		[XmlElement("requirement")]
		public EffectGroupRequirement[] Requirement;

		[XmlElement("passive_effect")]
		public PassiveEffect[] PassiveEffect;

		[XmlElement("effect_description")]
		public EffectDescription[] EffectDescription;
		#endregion

		public EffectGroup()
        {

        }
    }
}
