using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: CharacterSheet</summary>
    [Serializable, DataContract]
    public partial class CharacterSheet {
        /// <summary>Creates a new instance of <see cref="CharacterSheet"/></summary>
        public CharacterSheet() {
            this.AbilityScores = new AbilityScores();
            this.Hitpoints = new Hitpoints();
            this.Details = new Details();
            this.Defenses = new Defenses(Details);
            this.Feats = new FeatCollection();
            this.Powers = new List<Power>();
            this.Proficiencies = new Proficiencies();
            this.Skills = SkillScore.Create();            
        }
    }
}
