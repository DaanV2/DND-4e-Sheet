using System;
using System.Windows.Controls;
using DaanV2.DND.Pages;

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
    }
}
