using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: SheetConverter</summary>
    public static partial class SheetConverter {
        /// <summary>
        /// 
        /// </summary>
        private static void CharacterSheet(XmlNode Element, CharacterSheet Receiver) {
            SheetConverter.CharacterSheetDetails(Element["Details"], Receiver);
            SheetConverter.CharacterAbilityScores(Element["AbilityScores"], Receiver);
            SheetConverter.CharacterStatBlock(Element["StatBlock"], Receiver);
            SheetConverter.CharacterRulesElementTally(Element["RulesElementTally"], Receiver);
            SheetConverter.CharacterPowerStats(Element["PowerStats"], Receiver);

            //Others
            Int32 Count = Element.ChildNodes.Count;
            String Name;

            for (Int32 I = 0; I < Count; I++) {
                Name = Element.ChildNodes[I].Name;

                if (Name == "AbilityScores") {
                }
            }
        }
    }
}
