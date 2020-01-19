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
        public static Int32 ToInt(this XmlAttribute Atr, Int32 Default = 0) {
            Int32 Out = Default;

            if (Int32.TryParse(Atr?.Value ?? String.Empty, out Out)) {
                return Out;
            }

            return Default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Node"></param>
        /// <param name="Name"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public static Int32 AttributeToInt(this XmlNode Node, String Name, Int32 Default = 0) {
            XmlAttribute Item = Node.Attributes[Name];

            return Item == null ?
                Default : 
                Item.ToInt(Default);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Node"></param>
        /// <param name="Name"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public static Int32 AttributeToInt(this XmlElement Node, String Name, Int32 Default = 0) {
            String Item = Node.GetAttribute(Name);

            if (String.IsNullOrEmpty(Item)) { return Default; }

            Int32 Out = Default;

            if (Int32.TryParse(Item, out Out)) {
                return Out;
            }

            return Default;
        }


    }
}
