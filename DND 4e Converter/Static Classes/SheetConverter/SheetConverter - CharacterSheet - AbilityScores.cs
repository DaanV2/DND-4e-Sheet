using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: SheetConverter</summary>
    public static partial class SheetConverter {
        /// <summary>
        /// 
        /// </summary>
        private static void CharacterAbilityScores(XmlElement Element, CharacterSheet Receiver) {
            Int32 Count = Element.ChildNodes.Count;
            XmlNode Child;
            String Name;
            AbilityScores AS = Receiver.AbilityScores;
            AbilityScore AB = null;

            for (Int32 I = 0; I < Count; I++) {
                Child = Element.ChildNodes[I];
                Name = Child.Name;

                switch (Name[0]) {
                    default:
                        AB = null;
                        break;
                    case 'C':
                        if (Name == "Constitution") { AB = AS.Constitution; }
                        else if (Name == "Charisma") { AB = AS.Charisma; }
                        break;
                    case 'I':
                        if (Name == "Intelligence") { AB = AS.Intelligence; }
                        break;
                    case 'D':
                        if (Name == "Dexterity") { AB = AS.Dexterity; }
                        break;
                    case 'S':
                        if (Name == "Strength") { AB = AS.Strength; }
                        break;
                    case 'W':
                        if (Name == "Wisdom") { AB = AS.Wisdom; }
                        break;
                }

                if (AB != null) {
                    AB.Score = Int32.Parse(Child.Attributes["score"].Value);
                }
            }
        }
    }
}
