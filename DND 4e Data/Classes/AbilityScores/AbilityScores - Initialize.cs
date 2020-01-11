using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: AbilityScores</summary>
    [Serializable, DataContract]
    public partial class AbilityScores {
        /// <summary>Creates a new instance of <see cref="AbilityScores"/></summary>
        public AbilityScores() {
            this.Charisma = new AbilityScore();
            this.Constitution = new AbilityScore();
            this.Dexterity = new AbilityScore();
            this.Intelligence = new AbilityScore();
            this.Strength = new AbilityScore();
            this.Wisdom = new AbilityScore();
        }
    }
}
