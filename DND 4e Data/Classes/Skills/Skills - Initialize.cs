using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Skills</summary>
    [Serializable, DataContract]
    public partial class Skills {
        /// <summary>Creates a new instance of <see cref="Skills"/></summary>

        public Skills(Details details, AbilityScores Scores) {
            this.Items = new List<SkillScore> {
                new SkillScore("Acrobatics", details, Scores.Dexterity),
                new SkillScore("Arcana", details, Scores.Intelligence),
                new SkillScore("Athletics", details, Scores.Strength),
                new SkillScore("Bluff", details, Scores.Charisma),
                new SkillScore("Diplomacy", details, Scores.Charisma),
                new SkillScore("Dungeoneering", details, Scores.Wisdom),
                new SkillScore("Endurance", details, Scores.Constitution),
                new SkillScore("Heal", details, Scores.Wisdom),
                new SkillScore("History", details, Scores.Intelligence),
                new SkillScore("Insight", details, Scores.Wisdom),
                new SkillScore("Intimidate", details, Scores.Charisma),
                new SkillScore("Nature", details, Scores.Wisdom),
                new SkillScore("Perception", details, Scores.Wisdom),
                new SkillScore("Religion", details, Scores.Intelligence),
                new SkillScore("Stealth", details, Scores.Dexterity),
                new SkillScore("Streetwise", details, Scores.Charisma),
                new SkillScore("Thievery", details, Scores.Dexterity)
            };
        }
    }
}