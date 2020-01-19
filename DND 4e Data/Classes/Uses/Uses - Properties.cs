using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace DaanV2.DND {
    public partial class Uses {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Used { 
            get => this._Used;
            set {
                if (value > -1 && value <= this.Max) {
                    this._Used = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Used)));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Int32 Max { 
            get => this._Max;
            set {
                this._Max = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Max)));
            }
        }
    }
}
