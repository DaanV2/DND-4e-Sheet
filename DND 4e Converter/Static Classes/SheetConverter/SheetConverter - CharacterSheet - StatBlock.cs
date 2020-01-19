using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: SheetConverter</summary>
    public static partial class SheetConverter {
        /// <summary>
        /// 
        /// </summary>
        private static void CharacterStatBlock(XmlElement Element, CharacterSheet Receiver) {
            Int32 Count = Element.ChildNodes.Count;
            XmlNode Child;
            Int32 Value;
            String Name;

            for (Int32 I = 0; I < Count; I++) {
                Child = Element.ChildNodes[I];
                Value = Child.AttributeToInt("value");
                Name = Child["alias"].AttributeToString("name");

                switch (Name[0]) {
                    //A
                    case 'A':
                        if (Name == "AC" || Name == "Armor Class") {
                            ElementConverter.ToDefenseScore(Child, Receiver.Defenses.ArmorClass);
                        }
                        else if (Name.Contains("Acrobatics")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Acrobatics"));
                        }
                        else if (Name.Contains("Arcana")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Arcana"));
                        }
                        else if (Name.Contains("Athletics")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Athletics"));
                        }

                        break;
                    //B
                    case 'B':
                        if (Name.Contains("Bluff")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Bluff"));
                        }

                        break;
                    //D
                    case 'D':
                        if (Name.Contains("Diplomacy")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Diplomacy"));
                        }
                        else if (Name.Contains("Dungeoneering")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Dungeoneering"));
                        }

                        break;
                    //E
                    case 'E':
                        if (Name.Contains("Endurance")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Endurance"));
                        }

                        break;
                    //F
                    case 'F':
                        if (Name == "Fortitude" || Name == "Fortitude Defense") {
                            ElementConverter.ToDefenseScore(Child, Receiver.Defenses.Fortitude);
                        }

                        break;
                    //H
                    case 'H':
                        if (Name == "Hit Points") {
                            Receiver.Hitpoints.Max = Value;
                        }
                        else if (Name == "Healing Surges") {
                            Receiver.Hitpoints.Surges = Value;
                        }
                        else if (Name.Contains("Heal")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Heal"));
                        }
                        else if (Name.Contains("History")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("History"));
                        }

                        break;
                    //I
                    case 'I':
                        if (Name.Contains("Insight")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Insight"));
                        }
                        else if (Name.Contains("Intimidate")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Intimidate"));
                        }

                        break;
                    //N
                    case 'N':
                        if (Name.Contains("Nature")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Nature"));
                        }

                        break;
                    //P
                    case 'P':
                        if (Name.Contains("Perception")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Perception"));
                        }

                        break;
                    //R
                    case 'R':
                        if (Name == "Reflex" || Name == "Reflex Defense") {
                            ElementConverter.ToDefenseScore(Child, Receiver.Defenses.Reflex);
                        }
                        else if (Name.Contains("Religion")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Religion"));
                        }

                        break;
                    //S
                    case 'S':
                        if (Name.Contains("Stealth")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Stealth"));
                        }
                        else if (Name.Contains("Streetwise")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Streetwise"));
                        }

                        break;
                    //T
                    case 'T':
                        if (Name.Contains("Thievery")) {
                            ElementConverter.ToSkillScore(Child, Receiver.Skills.Get("Thievery"));
                        }

                        break;
                    //W
                    case 'W':
                        if (Name == "Will" || Name == "Will Defense") {
                            ElementConverter.ToDefenseScore(Child, Receiver.Defenses.Reflex);
                        }

                        break;
                    //X
                    case 'X':
                        if (Name == "XP Needed") {
                            Receiver.Details.XP = Element.AttributeToInt("value");
                        }

                        break;
                }
            }
        }
    }
}
