using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    public partial class CharacterSheet {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public AbilityScores AbilityScores { get => this._AbilityScores; set => this._AbilityScores = value; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Details Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Defenses Defenses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public FeatCollection Feats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Proficiencies Proficiencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Hitpoints Hitpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Power> Powers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<SkillScore> Skills { get; set; }

    }
}
