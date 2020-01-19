using System;
using System.Windows;
using System.Windows.Controls;

namespace DaanV2.DND.Pages {
    /// <summary>
    /// Interaction logic for CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page {
        public CharacterPage() {
            this.InitializeComponent();
        }

        private void ButtonSave_Click(Object sender, RoutedEventArgs e) {
            if (this.DataContext is CharacterSheet CS) {
                Storage.Set(CS);
            }
        }
    }
}
