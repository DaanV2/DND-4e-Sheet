using System;
using System.IO;
using DaanV2.DND;

namespace Debugger {
    ///DOLATER <summary>add description for class: SheetConverterTest</summary>
    public partial class SheetConverterTest {
        public static void ConvertAll() {
            String Folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String[] Files = Directory.GetFiles(Folder, "*.dnd4e", SearchOption.AllDirectories);

            foreach (String F in Files) {
                CharacterSheet Item = DaanV2.DND.Converter.SheetConverter.Convert(F);
                Console.WriteLine(Item.Details.Name);
                Storage.Set(Item);
            }
        }
    }
}
