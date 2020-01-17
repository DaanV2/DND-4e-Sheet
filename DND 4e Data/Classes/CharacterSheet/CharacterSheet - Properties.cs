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
        public List<SkillScore> Skills { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Power> Powers { get; set; }
    }
}
