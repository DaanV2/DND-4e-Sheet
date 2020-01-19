using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: ElementConverter</summary>
    public static partial class ElementConverter {
        public static void ToProficiency(XmlNode Node, CharacterSheet Receiver, String Type, String Name) {
            if (Type == "Language") {
                Receiver.Proficiencies.Languages.Add(Name);
            }
            else if (Name.Contains("Weapon") || Name.Contains("Melee") || Name.Contains("Ranged")) {
                Receiver.Proficiencies.Weapons.Add(Name);
            }
            else if (Name.Contains("Armor") || Name.Contains("Shield")) {
                Receiver.Proficiencies.Armor.Add(Name);
            }
            else {
                Receiver.Proficiencies.Other.Add(Name);
            }
        }
    }
}
