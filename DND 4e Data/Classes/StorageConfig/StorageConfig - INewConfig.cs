using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaanV2;
using DaanV2.Config;

namespace DaanV2.DND {
    public partial class StorageConfig : INewConfig {
        /// <summary>
        /// 
        /// </summary>
        public void SetNewInformation() {
            this.CharacterFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DND\4e\Characters\";

            Directory.CreateDirectory(this.CharacterFolder);
        }
    }
}
