using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: FeatCollection</summary>
    [Serializable, DataContract]
    public partial class FeatCollection {
        /// <summary>Creates a new instance of <see cref="FeatCollection"/></summary>
        public FeatCollection() {
            this.ClassFeats = new List<SimpleInfo>();
            this.Feats = new List<SimpleInfo>();
            this.RacialFeats = new List<SimpleInfo>();
        }
    }
}
