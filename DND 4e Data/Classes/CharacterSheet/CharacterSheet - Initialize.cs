using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: CharacterSheet</summary>
    public partial class CharacterSheet {
        /// <summary>Creates a new instance of <see cref="CharacterSheet"/></summary>
        public CharacterSheet() {
            this.AbilityScores = new AbilityScores();
            this.Details = new Details();
            this.Skills = new Skills(this.Details, this.AbilityScores);
        }
    }
}
