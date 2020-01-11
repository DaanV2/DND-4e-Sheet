using System;
using System.Windows.Controls;
using DaanV2.DND.Pages;
using Microsoft.Win32;

namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: CharacterController</summary>
    public static partial class CharacterController {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        public static Page LoadCharacter(String Filepath) {
            CharacterPage Page = new CharacterPage {
                DataContext = Storage.Get(Filepath)
            };
            return Page;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        public static Page LoadCharacter(CharacterSheet Character) {
            CharacterPage Page = new CharacterPage {
                DataContext = Character
            };
            return Page;
        }

        public static void NewCharacter() {
            SaveFileDialog SFD = new SaveFileDialog() {
                Title = "New character",
                Filter = "json file|*.json",
                InitialDirectory = Storage.Config.CharacterFolder,
                AddExtension = true
            };

            if (SFD.ShowDialog() == true) {
                String Name = System.IO.Path.GetFileNameWithoutExtension(SFD.FileName);
                CharacterSheet Character = new CharacterSheet();
                Character.Details.Name = Name;
                Storage.Set(Character);
                PageController.Load(CharacterController.LoadCharacter(Character));
            }
        }
    }
}
