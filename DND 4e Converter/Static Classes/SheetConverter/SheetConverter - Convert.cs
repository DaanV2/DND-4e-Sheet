using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.Win32;

namespace DaanV2.DND.Converter {
    ///DOLATER <summary>add description for class: SheetConverter</summary>
    public static partial class SheetConverter {

        public static List<CharacterSheet> Convert() {
            OpenFileDialog OFD = new OpenFileDialog() {
                Title = "Convert .dnd4e file(s)",
                Filter = "dnd 4e files|*.dnd4e",
                Multiselect = true,
                CheckFileExists = true,
                InitialDirectory = Storage.Config.CharacterFolder
            };
            List<CharacterSheet> Out = null;

            if (OFD.ShowDialog() == true) {
                Out = new List<CharacterSheet>();
                
                foreach (String F in OFD.FileNames) {
                    Out.Add(Convert(F));
                }
            }

            return Out;
        }

        /// <summary>
        /// Converts .dnd4e as best as possible
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public static CharacterSheet Convert(String Filepath) {
            XmlDocument Document = new XmlDocument();
            CharacterSheet character = new CharacterSheet();
            Document.Load(Filepath);

            SheetConverter.D20Character(Document["D20Character"], character);

            return character;
        }
    }
}
