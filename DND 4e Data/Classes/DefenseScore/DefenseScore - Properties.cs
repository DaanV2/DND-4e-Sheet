using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class DefenseScore {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Score { get {
                Int32 Out = this._Detaits == null ? 10 : this._Detaits.HalfLevel + 10;
                Out += this.Armor + this.Class + this.Feat + this.Enhanced + this.Misc;

                return Out;
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Armor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Class { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Feat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Enhanced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Misc { get; set; }
    }
}
