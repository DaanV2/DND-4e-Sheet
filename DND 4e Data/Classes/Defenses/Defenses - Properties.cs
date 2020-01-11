using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class Defenses {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DefenseScore ArmorClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DefenseScore Fortitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DefenseScore Reflex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DefenseScore Will { get; set; }
    }
}
