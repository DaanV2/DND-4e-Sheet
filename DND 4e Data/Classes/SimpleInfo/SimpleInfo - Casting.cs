using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class SimpleInfo {
        /// <summary>Impliciticly casts a tuple of string into a <see cref="SimpleInfo"/>s</summary>
        /// <param name="Data"></param>
        public static implicit operator SimpleInfo((String Name, String Text) Data) {
            return new SimpleInfo(Data.Name, Data.Text);
        }
    }
}
