using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace DaanV2.DND.Pages {
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page {
        public StartPage() {
            InitializeComponent();
        }

        private void NewButton_Click(Object sender, RoutedEventArgs e) {
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

        private void Character_Click(Object sender, RoutedEventArgs e) {

        }   
    }
}
