using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Proficiencies</summary>
    [DataContract, Serializable]
    public partial class Proficiencies {
        /// <summary>Creates a new instance of <see cref="Proficiencies"/></summary>
        public Proficiencies() {
            this.Armor = new List<String>();
            this.Languages = new List<String>();
            this.Other = new List<String>();
            this.Weapons = new List<String>();
        }
    }
}
