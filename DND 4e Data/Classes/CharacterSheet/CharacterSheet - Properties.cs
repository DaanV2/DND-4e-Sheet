using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class CharacterSheet {
        /// <summary>
        /// 
        /// </summary>
        public AbilityScores AbilityScores { get => _AbilityScores; set => _AbilityScores = value; }

        /// <summary>
        /// 
        /// </summary>
        public Details Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Skills Skills { get; set; }
    }
}
