using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: SkillScore</summary>
    [Serializable, DataContract]
    public partial class SkillScore {
        /// <summary>Creates a new instance of <see cref="SkillScore"/></summary>
        public SkillScore(String Name, Details details, AbilityScore Base) {
            this.Name = Name;
            this._Details = details;
            this._Base = Base;
            this.ArmorPenalty = 0;
            this.Misc = 0;
            this.Trained = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="details"></param>
        /// <param name="Scores"></param>
        /// <returns></returns>
        public static List<SkillScore> Create(Details details, AbilityScores Scores) {
            return new List<SkillScore> {
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
