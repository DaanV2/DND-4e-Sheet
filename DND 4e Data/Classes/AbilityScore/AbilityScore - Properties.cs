using System;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    public partial class AbilityScore {
        /// <summary>Gets or sets the score of this ability</summary>
        [DataMember]
        public Int32 Score { get => this._Score; set => this._Score = value; }

        /// <summary>Gets the modifier of this score</summary>
        [DataMember]
        public Int32 Modifier { get => (this.Score - 10) / 2; }
    }
}
