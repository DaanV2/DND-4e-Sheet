using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class Proficiencies {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<String> Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<String> Weapons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<String> Armor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<String> Other { get; set; }
    }
}
