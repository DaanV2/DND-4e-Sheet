using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: SheetConverter</summary>
    public static partial class SheetConverter {
        /// <summary>
        /// 
        /// </summary>
        private static void D20Character(XmlElement Element, CharacterSheet Receiver) {
            Int32 Count = Element.ChildNodes.Count;
            String Name;

            for (Int32 I = 0; I < Count; I++) {
                Name = Element.ChildNodes[I].Name;

                if (Name == "CharacterSheet") {
                    SheetConverter.CharacterSheet(Element.ChildNodes[I], Receiver);
                }
            }
        }
    }
}
