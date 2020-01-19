using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: SheetConverter</summary>
    public static partial class SheetConverter {
        /// <summary>
        /// 
        /// </summary>
        private static void CharacterRulesElementTally(XmlElement Element, CharacterSheet Receiver) {
            Int32 Count = Element.ChildNodes.Count;
            XmlNode Child;
            String Type;
            String Name;

            for (Int32 I = 0; I < Count; I++) {
                Child = Element.ChildNodes[I];
                Type = Child.AttributeToString("type");
                Name = Child.AttributeToString("name");

                if (Type == "Racial Trait" || Type == "Feat" || 
                    Type == "Class Feature" || Type == "Paragon Path") {
                    ElementConverter.ToFeat(Child, Receiver.Feats, Type, Name);
                }
                else if (Type == "Proficiency" || Type == "Language") {
                    ElementConverter.ToProficiency(Child, Receiver, Type, Name);
                }
                else if (Type == "Race") {
                    Receiver.Details.Race = Name;
                }
                else if (Type == "Class") {
                    Receiver.Details.Class = Name;
                }
            }
        }
    }
}
