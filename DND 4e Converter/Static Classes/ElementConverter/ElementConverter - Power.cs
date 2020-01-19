using System;
using System.Collections.Generic;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: ElementConverter</summary>
    public static partial class ElementConverter {
        public static void ToPower(XmlNode Node, CharacterSheet Receiver) {
            Power P = new Power();
            Receiver.Powers.Add(P);
            P.Info.Title = Node.AttributeToString("name");

            Int32 Count = Node.ChildNodes.Count;
            String Name;
            String ElementName;
            XmlNode Child;
            List<XmlNode> Weapons = new List<XmlNode>();

            for (Int32 I = 0; I < Count; I++) {
                Child = Node.ChildNodes[I];
                ElementName = Child.Name;
                Name = Child.AttributeToString("name");

                if (ElementName == "specific") {
                    if (Name == "Power Usage") {
                        P.Info.AtWill = Child.InnerText.Contains("At-Will");
                        P.Info.Encounter = Child.InnerText.Contains("Encounter");
                        P.Info.Daily = Child.InnerText.Contains("Daily");
                    }
                    else if (Name == "Action Type") {
                        P.Info.ActionType = Child.InnerText.Replace("Action", String.Empty).Trim();
                    }
                }
                else if (ElementName == "Weapon") {
                    Weapons.Add(Child);
                }
            }

            Count = Weapons.Count;
            if (Count > 0) {
                WeaponToPower(Weapons[0], P);

                for (Int32 I = 1; I < Count; I++) {
                    OverlapWeaponToPower(Weapons[I], P);
                }
            }
        }

        internal static void WeaponToPower(XmlNode Node, Power Receiver) {
            String Name = Node.AttributeToString("name");
            String AttackBonus = Node["AttackBonus"]?.InnerText.Trim() ?? String.Empty;
            String Damage = Node["Damage"]?.InnerText.Trim() ?? String.Empty;

            Receiver.Info.AttackBonus = AttackBonus;
            Receiver.Info.AttackStat = Node["AttackStat"]?.InnerText.Trim() ?? String.Empty;
            Receiver.Info.DefenseStat = Node["Defense"]?.InnerText.Trim() ?? String.Empty;

            Receiver.Attributes.Add(new SimpleInfo(Name + ":", $"+{AttackBonus}, {Damage}"));
        }

        internal static void OverlapWeaponToPower(XmlNode Node, Power Receiver) {
            String Name = Node.AttributeToString("name");
            String AttackBonus = Node["AttackBonus"]?.InnerText.Trim() ?? String.Empty;
            String Damage = Node["Damage"]?.InnerText.Trim() ?? String.Empty;

            if (Receiver.Info.AttackBonus != AttackBonus)
                Receiver.Info.AttackBonus = String.Empty;

            if (Receiver.Info.AttackStat != (Node["AttackStat"]?.InnerText.Trim() ?? String.Empty))
                Receiver.Info.AttackStat = String.Empty;

            if (Receiver.Info.DefenseStat != (Node["Defense"]?.InnerText.Trim() ?? String.Empty))
                Receiver.Info.DefenseStat = String.Empty;

            Receiver.Attributes.Add(new SimpleInfo(Name + ":", $"+{AttackBonus}, {Damage}"));
        }
    }
}
