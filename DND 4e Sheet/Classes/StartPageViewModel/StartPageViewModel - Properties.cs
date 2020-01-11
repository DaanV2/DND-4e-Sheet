using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.DND {
    public partial class StartPageViewModel {
        ///DOLATER Add description<summary></summary>
        public List<CharacterFile> Characters {
            get => this._Characters;
            set {
                this._Characters = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Characters)));
            }
        }
    }
}
