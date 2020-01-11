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
        public SkillScore(String Name) {
            this.Name = Name;
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
        public static List<SkillScore> Create() {
            return new List<SkillScore> {
                new SkillScore("Acrobatics"),
                new SkillScore("Arcana"),
                new SkillScore("Athletics"),
                new SkillScore("Bluff"),
                new SkillScore("Diplomacy"),
                new SkillScore("Dungeoneering"),
                new SkillScore("Endurance"),
                new SkillScore("Heal"),
                new SkillScore("History"),
                new SkillScore("Insight"),
                new SkillScore("Intimidate"),
                new SkillScore("Nature"),
                new SkillScore("Perception"),
                new SkillScore("Religion"),
                new SkillScore("Stealth"),
                new SkillScore("Streetwise"),
                new SkillScore("Thievery")
            };
        }
    }
}
