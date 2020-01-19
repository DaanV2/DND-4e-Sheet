using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: SheetConverter</summary>
    public static partial class SheetConverter {
        /// <summary>
        /// 
        /// </summary>
        private static void CharacterSheetDetails(XmlElement Element, CharacterSheet Receiver) {
            Int32 Count = Element.ChildNodes.Count;
            XmlNode Child;
            String Name;

            for (Int32 I = 0; I < Count; I++) {
                Child = Element.ChildNodes[I];
                Name = Child.Name;

                switch (Name[0]) {
                    case 'L':
                        if (Name == "Level") { Receiver.Details.Level = Int32.Parse(Child.InnerText); }
                        break;
                    case 'n':
                        if (Name == "name") { Receiver.Details.Name = Child.InnerText.Trim(); }
                        break;
                    default:
                        Receiver.Details.OtherInfo.Add(new SimpleInfo(Name, Child.InnerText.Trim()));
                        break;
                }
            }
        }
    }
}
