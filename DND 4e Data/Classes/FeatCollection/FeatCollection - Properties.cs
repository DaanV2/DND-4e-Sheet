using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class FeatCollection {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<SimpleInfo> ClassFeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<SimpleInfo> RacialFeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<SimpleInfo> Feats { get; set; }
    }
}
