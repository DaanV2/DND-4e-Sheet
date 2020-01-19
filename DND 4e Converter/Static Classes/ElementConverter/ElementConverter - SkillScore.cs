using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: ElementConverter</summary>
    public static partial class ElementConverter {
        public static void ToSkillScore(XmlNode Node, SkillScore Score) {
            if (Node == null || Score == null) {
                return;
            }

            String Alias = Node["alias"].AttributeToString("name");

            if (Alias == Score.Name) {
                Score.Bonus = Node.AttributeToInt("value");
            }
            else if (Alias.Contains("Trained")) {
                Score.Trained |= Node.AttributeToInt("value") > 0;
            }

            if (Node.Name == "Stat") {
                XmlNode Child;
                Int32 Count = Node.ChildNodes.Count;

                for (Int32 I = 0; I < Count; I++) {
                    Child = Node.ChildNodes[I];

                    String Type = Child.Attributes["type"]?.Value;
                    Int32 Value = Int32.Parse(Child.Attributes["value"]?.Value ?? "0");

                    if (!String.IsNullOrEmpty(Type)) {
                        if (Type == "Ability" || Type == "Feat" || Type == "Racial") {
                            Score.Misc += Value;
                        }
                        else if (Type == "Armor Penalty") {
                            Score.ArmorPenalty += Value;
                        }
                    }
                }
            }
        }
    }
}
