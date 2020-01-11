using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class StorageConfig {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public String CharacterFolder { get; set; }
    }
}
