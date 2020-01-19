using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DaanV2.DND.Pages {
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page {
        public StartPage() {
            this.InitializeComponent();
        }

        private void ButtonNewCharacter_Click(Object sender, RoutedEventArgs e) {
            CharacterController.NewCharacter();
        }

        private void ButtonImport_Click(Object sender, RoutedEventArgs e) {
            List<CharacterSheet> Items = Converter.SheetConverter.Convert();

            if (Items == null) {
                return;
            }

            foreach (CharacterSheet C in Items) {
                Storage.Set(C);
                CharacterController.LoadCharacter(C);
            }
        }
    }
}
