using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaanV2.Config;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Storage</summary>
    public static partial class Storage {
        /// <summary>Creates a new instance of <see cref="Storage"/></summary>
        static Storage() {
            Storage.Config = ConfigMapper.Get<StorageConfig>();
        }
    }
}
