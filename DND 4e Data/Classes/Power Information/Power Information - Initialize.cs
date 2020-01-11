﻿using System;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: PowerInformation</summary>
    [Serializable, DataContract]
    public partial class PowerInformation {
        /// <summary>Creates a new instance of <see cref="PowerInformation"/></summary>
        public PowerInformation() {
            this.ActionType = String.Empty;
            this.AdditionalEffects = String.Empty;
            this.AttackBonus = String.Empty;
            this.AtWill = true;
            this.Daily = false;
            this.Defense = String.Empty;
            this.Description = String.Empty;
            this.Encounter = false;
            this.Keywords = new String[] { };
            this.Range = String.Empty;
            this.Target = String.Empty;
            this.Title = String.Empty;
        }
    }
}
