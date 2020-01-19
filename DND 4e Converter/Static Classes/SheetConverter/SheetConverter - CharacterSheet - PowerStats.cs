using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: SheetConverter</summary>
    public static partial class SheetConverter {
        /// <summary>
        /// 
        /// </summary>
        private static void CharacterPowerStats(XmlElement Element, CharacterSheet Receiver) {
            Int32 Count = Element.ChildNodes.Count;

            for (Int32 I = 0; I < Count; I++) {
                ElementConverter.ToPower(Element.ChildNodes[I], Receiver);
            }
        }
    }
}
