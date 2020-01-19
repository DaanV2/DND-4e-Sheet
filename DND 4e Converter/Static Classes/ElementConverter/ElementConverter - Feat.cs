using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: ElementConverter</summary>
    public static partial class ElementConverter {
        public static void ToFeat(XmlNode Node, FeatCollection Receiver, String Type, String Name) {
            SimpleInfo Feat = new SimpleInfo(Name, String.Empty);

            if (Type == "Racial Trait") {
                Receiver.RacialFeats.Add(Feat);
            }
            else if (Type == "Class Feature") {
                Receiver.ClassFeats.Add(Feat);
            }
            else if (Type == "Feat") {
                Receiver.Feats.Add(Feat);
            }

            Int32 Count = Node.ChildNodes.Count;
            XmlNode Child;

            for (Int32 I = 0; I < Count; I++) {
                Child = Node.ChildNodes[I];

                if (Child.AttributeToString("name")== "Short Description") {
                    Feat.Text = Child.InnerText.Trim();
                }
            }

        }
    }
}
