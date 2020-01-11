using System;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: CharacterSheet</summary>
    [Serializable, DataContract]
    public partial class CharacterSheet {
        /// <summary>Creates a new instance of <see cref="CharacterSheet"/></summary>
        public CharacterSheet() {
            this.AbilityScores = new AbilityScores();
            this.Details = new Details();
            this.Skills = SkillScore.Create(this.Details, this.AbilityScores);
        }
    }
}
