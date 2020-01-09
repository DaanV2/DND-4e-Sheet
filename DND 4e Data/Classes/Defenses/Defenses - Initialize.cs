using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Defenses</summary>
    public partial class Defenses {
        /// <summary>Creates a new instance of <see cref="Defenses"/></summary>
        public Defenses(Details details) {
            this.ArmorClass = new DefenseScore(details);
            this.Fortitude = new DefenseScore(details);
            this.Reflex = new DefenseScore(details);
            this.Will = new DefenseScore(details);
        }
    }
}
