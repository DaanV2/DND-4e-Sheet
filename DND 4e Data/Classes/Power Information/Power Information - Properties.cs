using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class PowerInformation {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Boolean AtWill { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Boolean Encounter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Boolean Daily { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Range { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String AttackBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Defense { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String[] Keywords { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String ActionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String AdditionalEffects { get; set; }
    }
}
