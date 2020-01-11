using System;
using System.IO;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: CharacterFile</summary>
    public partial class CharacterFile {
        /// <summary>Creates a new instance of <see cref="CharacterFile"/></summary>
        public CharacterFile(String Filepath) {
            this.Filepath = Filepath;
            this.Name = Path.GetFileNameWithoutExtension(Filepath);
        }
    }
}
