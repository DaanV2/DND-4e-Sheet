using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace DaanV2.DND.UserControls {
    /// <summary>
    /// Interaction logic for CharacterFileControl.xaml
    /// </summary>
    public partial class CharacterFileControl : UserControl {
        public CharacterFileControl() {
            this.InitializeComponent();
        }

        private void ContextMenuRemove_Click(Object sender, RoutedEventArgs e) {
            if (this.DataContext is CharacterFile CF) {
                File.Delete(CF.Filepath);
            }

            this.DataContext = null;
        }

        private void ContextMenuOpen_Click(Object sender, RoutedEventArgs e) {
            if (this.DataContext is CharacterFile CF) {
                PageController.Load(CharacterController.LoadCharacter(CF.Filepath));
            }
            else {
                this.DataContext = null;
            }
        }
    }
}
