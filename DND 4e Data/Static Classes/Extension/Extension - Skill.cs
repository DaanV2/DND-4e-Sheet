using System;
using System.Collections.Generic;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Extension</summary>
    public static partial class Extension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static SkillScore Get(this List<SkillScore> Skills, String Name) {
            Int32 Count = Skills.Count;
            for (Int32 I = 0; I < Count; I++) {
                if (Skills[I].Name == Name) {
                    return Skills[I];
                }
            }

            return null;
        }
    }
}
