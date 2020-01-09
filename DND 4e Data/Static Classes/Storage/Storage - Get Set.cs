using System;
using System.IO;

namespace DaanV2.DND {
    public static partial class Storage {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public static CharacterSheet Get(String Filepath) {
            return Serialization.Serialization.Deserialize<CharacterSheet>("json", Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sheet"></param>
        /// <returns></returns>
        public static void Set(CharacterSheet Sheet) {
            String Filepath = Storage.Config.CharacterFolder + Sheet.Details.Name + ".json";
            Serialization.Serialization.Serialize(Sheet, "json", Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static String[] GetFiles() {
            return Directory.GetFiles(Storage.Config.CharacterFolder, ".json", SearchOption.AllDirectories);
        }
    }
}
