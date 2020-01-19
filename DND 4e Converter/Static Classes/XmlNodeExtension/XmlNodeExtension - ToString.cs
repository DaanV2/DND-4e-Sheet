using System;
using System.Xml;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: XmlNodeExtension</summary>
    public static partial class XmlNodeExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Atr"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public static String AttributeToString(this XmlAttribute Atr, String Default = "") {
            if (Atr == null) {
                return Default;
            }

            if (Atr.Value == null) {
                return Default;
            }

            return Atr.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Node"></param>
        /// <param name="Name"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public static String AttributeToString(this XmlNode Node, String Name, String Default = "") {
            if (Node == null) {
                return Default;
            }

            XmlAttribute Item = Node.Attributes[Name];

            return Item == null ?
                Default :
                Item.AttributeToString(Default);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Node"></param>
        /// <param name="Name"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public static String AttributeToString(this XmlElement Node, String Name, String Default = "") {
            if (Node == null) {
                return Default;
            }

            String Item = Node.GetAttribute(Name);

            return Item;
        }


    }
}
