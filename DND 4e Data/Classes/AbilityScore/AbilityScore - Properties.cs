using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class AbilityScore {
        /// <summary>Gets or sets the score of this ability</summary>
        public Int32 Score { get => _Score; set => _Score = value; }

        /// <summary>Gets the modifier of this score</summary>
        public Int32 Modifier { get => (this.Score - 10) / 2; }
    }
}
