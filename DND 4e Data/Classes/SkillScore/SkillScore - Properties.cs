using System;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    public partial class SkillScore {
        /// <summary>
        /// 
        /// </summary>
        public Int32 Bonus {
            get {
                Int32 Out = 0;
                Out += this._Base.Modifier + this._Details.HalfLevel + this.Misc + this.ArmorPenalty;

                if (this.Trained) {
                    Out += 5;
                }

                return Out;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Boolean Trained { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 ArmorPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Misc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Name { get; set; }
    }
}
