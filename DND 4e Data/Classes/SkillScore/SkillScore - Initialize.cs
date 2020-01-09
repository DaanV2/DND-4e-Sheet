using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: SkillScore</summary>
    public partial class SkillScore {
        /// <summary>Creates a new instance of <see cref="SkillScore"/></summary>
        public SkillScore(Details details, AbilityScore Base) {
            this._Details = details;
            this._Base = Base;
            this.ArmorPenalty = 0;
            this.Misc = 0;
            this.Trained = false;
        }
    }
}
