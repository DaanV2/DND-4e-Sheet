using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: ElementConverter</summary>
    public static partial class ElementConverter {
        public static void ToDefenseScore(XmlNode Node, DefenseScore Score) {
            if (Node == null)
                return;

            if (Node.Name == "Stat") {
                Int32 Count = Node.ChildNodes.Count;
                XmlNode Child;

                for (Int32 I = 0; I < Count; I++) {
                    Child = Node.ChildNodes[I];
                    String type = Child.AttributeToString("type");

                    if (String.IsNullOrEmpty(type))
                        continue;

                    switch (type[0]) {
                        case 'A':
                            if (type == "Ability" || type == "Armor") {
                                Score.Armor += Int32.Parse(Child.Attributes["value"].Value);
                            }
                            break;
                        case 'C':
                            if (type == "Class") {
                                Score.Class += Int32.Parse(Child.Attributes["value"].Value);
                            }
                            break;
                        case 'E':
                            if (type == "Enhancement") {
                                Score.Enhanced += Int32.Parse(Child.Attributes["value"].Value);
                            }
                            break;
                        case 'F':
                            if (type == "Feat" || type == "Feature") {
                                Score.Feat += Int32.Parse(Child.Attributes["value"].Value);
                            }
                            break;
                        case 'M':
                            if (type == "Misc") {
                                Score.Misc+= Int32.Parse(Child.Attributes["value"].Value);
                            }
                            break;
                    }
                }
            }
        }
    }
}
