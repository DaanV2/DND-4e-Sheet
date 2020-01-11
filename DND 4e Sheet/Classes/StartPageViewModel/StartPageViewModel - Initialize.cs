using System;
using System.Collections.Generic;

namespace DaanV2.DND {
    ///DOLATER <summary>Add description for class: StartPageViewModel</summary>
    public partial class StartPageViewModel {
        /// <summary>Creates a new instance of <see cref="StartPageViewModel"/></summary>
        public StartPageViewModel() {
            this.Characters = new List<CharacterFile>();

            foreach (String F in Storage.GetFiles()) {
                this.Characters.Add(new CharacterFile(F));
            }
        }
    }
}
